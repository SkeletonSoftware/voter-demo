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
        /// <returns>výstupní objekt</returns>
        ModelCoreResult<EditNextCampaignOutputModel> EditNext(EditNextCampaignInputModel input);
    }
}

