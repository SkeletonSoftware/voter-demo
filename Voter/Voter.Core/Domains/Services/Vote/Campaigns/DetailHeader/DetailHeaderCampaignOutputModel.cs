using System;

namespace Voter.Core.Domains.Services.Vote.Campaigns
{
    /// <summary>
    /// 
    /// Výstupní model entity - Kampaně
    /// </summary>
    public class DetailHeaderCampaignOutputModel 
    {
        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Název
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Poznámka
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Otázka
        /// </summary>
        public int? ID_Question { get; set; }

    }
}

