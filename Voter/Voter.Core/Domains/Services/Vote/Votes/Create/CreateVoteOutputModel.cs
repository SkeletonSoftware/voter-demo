using System;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// 
    /// Výstupní model entity - Hlasy
    /// </summary>
    public class CreateVoteOutputModel 
    {
        /// <summary>
        /// Jedinečné ID otázky
        /// </summary>
        public int? ID { get; set; }

    }
}

