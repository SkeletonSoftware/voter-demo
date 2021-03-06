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
        /// Přehled otázek kampaně
        /// </summary>
        /// <param name="input">vstupní objekt</param>
        /// <returns>kolekce výstupních objektů</returns>
        ModelCoreResult<ICollection<ListQuestionCampaignOutputModel>> ListQuestion(ListQuestionCampaignInputModel input);
    }
}

