using System;

namespace Voter.Core.Domains.Services.Vote.Campaigns
{
    /// <summary>
    /// Přehled otázek kampaně
    /// Vstupní model entity - Kampaně
    /// </summary>
    public class ListQuestionCampaignInputModel 
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

        /// <summary>
        /// Název
        /// </summary>
        public string DisplayName { get; set; }

    }
}

