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
        public ModelCoreResult<DeleteCampaignOutputModel> Delete(DeleteCampaignInputModel input)
        {
            // zalozim result
            var result = new ModelCoreResult<DeleteCampaignOutputModel>();

            using (var conn = GetConnection())
            {
                try
                {
                    // volani stored proc
                    string proc = "VT_Campaign_DEL";
                    var param = new DynamicParameters(input);
                    LogQuery(proc, input);
                    result.Data = conn.Query<DeleteCampaignOutputModel>(proc, param: param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
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

