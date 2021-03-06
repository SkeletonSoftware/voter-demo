using System;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// 
    /// Výstupní model entity - Hlasy
    /// </summary>
    public class ListVoteOutputModel 
    {
        /// <summary>
        /// Jedinečné ID otázky
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// ID_Question
        /// </summary>
        public int? ID_Question { get; set; }

        /// <summary>
        /// Result
        /// </summary>
        public bool? Result { get; set; }

        /// <summary>
        /// UID
        /// </summary>
        public Guid UID { get; set; }

        /// <summary>
        /// DateCreated
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Aktivní
        /// </summary>
        public bool IsActive { get; set; }

    }
}

