using System.Collections.Generic;
using Voter.Core.Utils.Results;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// Rozhraní služby pro entitu Hlasy
    /// </summary>
    public partial interface IVoteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">vstupní objekt</param>
        /// <returns>kolekce výstupních objektů</returns>
        ModelCoreResult<ICollection<ListVoteOutputModel>> List(ListVoteInputModel input);
    }
}

