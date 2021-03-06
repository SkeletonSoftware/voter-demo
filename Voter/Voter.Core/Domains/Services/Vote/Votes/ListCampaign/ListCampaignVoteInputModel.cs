using System;

namespace Voter.Core.Domains.Services.Vote.Votes
{
    /// <summary>
    /// 
    /// Vstupní model entity - Hlasy
    /// </summary>
    public class ListCampaignVoteInputModel 
    {
        /// <summary>
        /// ID_Login
        /// </summary>
        public Guid ID_Login { get; set; }

        /// <summary>
        /// Top
        /// </summary>
        public int? Top { get; set; }

        /// <summary>
        /// Jedinečné ID otázky
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Kampaň
        /// </summary>
        public int? ID_Campaign { get; set; }

    }
}

