using System;

namespace Voter.Core.Domains.Services.Vote.Campaigns
{
    /// <summary>
    /// 
    /// Výstupní model entity - Kampaně
    /// </summary>
    public class ListCampaignOutputModel 
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
        /// Aktivní
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Poznámka
        /// </summary>
        public string Description { get; set; }

    }
}

