using Dapper;
using Voter.Core.Domains.Services.Common;
using Voter.Core.Utils.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// Implementace služby pro entitu - Hlasy
    /// </summary>
    public partial class VoteService : BaseService, IVoteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">vstupní objekt</param>
        /// <returns>výstupní objekt</returns>
        public ModelCoreResult<CreateVoteOutputModel> Create(CreateVoteInputModel input)
        {
            // zalozim result
            var result = new ModelCoreResult<CreateVoteOutputModel>();

            using (var conn = GetConnection())
            {
                // parametry
                var param = new DynamicParameters();
                param.Add("ID_Login", input.ID_Login, dbType: System.Data.DbType.Guid);
                param.Add("ID_Question", input.ID_Question, dbType: System.Data.DbType.Int32);
                param.Add("Result", input.Result, dbType: System.Data.DbType.Boolean);
                param.Add("UID", input.UID, dbType: System.Data.DbType.Guid);
                param.Add("ID", input.ID, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);
                try
                {
                    // volani stored proc
                    string proc = "VT_Vote_NEW";
                    LogQuery(proc, input);
                    conn.Query<CreateVoteOutputModel>(proc, param: param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                    // vytazeni output parametru
                    result.Data = new CreateVoteOutputModel
                    {
                        ID = param.Get<int>("ID"),
                    };
                }
                // kontrola validaci
                catch (SqlException e)
                {
                    TryValidation(e, result);
                }
            }
            
            return result;
        }

    }
}

