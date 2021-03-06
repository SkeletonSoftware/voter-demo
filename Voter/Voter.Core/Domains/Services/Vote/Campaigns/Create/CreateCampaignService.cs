using Dapper;
using Voter.Core.Domains.Services.Common;
using Voter.Core.Utils.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Voter.Core.Domains.Services.Vote.Campaigns
{
    /// <summary>
    /// Implementace služby pro entitu - Kampaně
    /// </summary>
    public partial class CampaignService : BaseService, ICampaignService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">vstupní objekt</param>
        /// <returns>výstupní objekt</returns>
        public ModelCoreResult<CreateCampaignOutputModel> Create(CreateCampaignInputModel input)
        {
            // zalozim result
            var result = new ModelCoreResult<CreateCampaignOutputModel>();

            using (var conn = GetConnection())
            {
                // parametry
                var param = new DynamicParameters();
                param.Add("ID_Login", input.ID_Login, dbType: System.Data.DbType.Guid);
                param.Add("DisplayName", input.DisplayName, dbType: System.Data.DbType.String);
                param.Add("Description", input.Description, dbType: System.Data.DbType.String);
                param.Add("ID", input.ID, dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);
                try
                {
                    // volani stored proc
                    string proc = "VT_Campaign_NEW";
                    LogQuery(proc, input);
                    conn.Query<CreateCampaignOutputModel>(proc, param: param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                    // vytazeni output parametru
                    result.Data = new CreateCampaignOutputModel
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

