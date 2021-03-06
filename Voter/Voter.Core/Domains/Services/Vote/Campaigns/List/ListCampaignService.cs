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
        /// <returns>kolekce výstupních objektů</returns>
        public ModelCoreResult<ICollection<ListCampaignOutputModel>> List(ListCampaignInputModel input)
        {
            // zalozim result
            var result = new ModelCoreResult<ICollection<ListCampaignOutputModel>>();

            using (var conn = GetConnection())
            {
                try
                {
                    // volani stored proc
                    string proc = "VT_Campaign_ALL";
                    var param = new DynamicParameters(input);
                    LogQuery(proc, input);
                    result.Data = conn.Query<ListCampaignOutputModel>(proc, param: param, commandType: System.Data.CommandType.StoredProcedure).ToList();
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

