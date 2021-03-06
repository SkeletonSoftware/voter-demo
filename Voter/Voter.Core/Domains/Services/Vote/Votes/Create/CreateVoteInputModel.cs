using System;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// 
    /// Vstupní model entity - Hlasy
    /// </summary>
    public class CreateVoteInputModel 
    {
        /// <summary>
        /// ID_Login
        /// </summary>
        public Guid ID_Login { get; set; }

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
        /// Jedinečné ID otázky
        /// </summary>
        public int? ID { get; set; }

    }
}

