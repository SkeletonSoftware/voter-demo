using System.Collections.Generic;
using Voter.Core.Utils.Results;

namespace Voter.Core.Domains.Services.Vote.Campaigns
{
    /// <summary>
    /// Rozhraní služby pro entitu Kampaně
    /// </summary>
    public partial interface ICampaignService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">vstupní objekt</param>
        /// <returns>kolekce výstupních objektů</returns>
        ModelCoreResult<ICollection<ListCampaignOutputModel>> List(ListCampaignInputModel input);
    }
}

