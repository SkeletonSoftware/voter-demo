using System.Collections.Generic;
using Voter.Core.Utils.Results;

namespace Voter.Core.Domains.Services.Vote.Questions
{
    /// <summary>
    /// Rozhraní služby pro entitu Otázky
    /// </summary>
    public partial interface IQuestionService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">vstupní objekt</param>
        /// <returns>výstupní objekt</returns>
        ModelCoreResult<CreateCampaignQuestionOutputModel> CreateCampaign(CreateCampaignQuestionInputModel input);
    }
}

