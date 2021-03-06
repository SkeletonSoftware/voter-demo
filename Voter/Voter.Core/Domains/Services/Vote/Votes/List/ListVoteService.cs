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
        /// <returns>kolekce výstupních objektů</returns>
        public ModelCoreResult<ICollection<ListVoteOutputModel>> List(ListVoteInputModel input)
        {
            // zalozim result
            var result = new ModelCoreResult<ICollection<ListVoteOutputModel>>();

            using (var conn = GetConnection())
            {
                try
                {
                    // volani stored proc
                    string proc = "VT_Vote_ALL";
                    var param = new DynamicParameters(input);
                    LogQuery(proc, input);
                    result.Data = conn.Query<ListVoteOutputModel>(proc, param: param, commandType: System.Data.CommandType.StoredProcedure).ToList();
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

