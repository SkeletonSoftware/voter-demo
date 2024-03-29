using System;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// 
    /// Výstupní model entity - Hlasy
    /// </summary>
    public class ListCampaignVoteOutputModel 
    {
        /// <summary>
        /// Count
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Result
        /// </summary>
        public bool? Result { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// ID_Question
        /// </summary>
        public int? ID_Question { get; set; }

        /// <summary>
        /// Název
        /// </summary>
        public string DisplayName { get; set; }

    }
}

