using System;

namespace Voter.Core.Domains.Services.Vote.Campaigns
{
    /// <summary>
    /// 
    /// Vstupní model entity - Kampaně
    /// </summary>
    public class ListCampaignInputModel 
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
        /// Jedinečné ID kampaně
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Název
        /// </summary>
        public string DisplayName { get; set; }

    }
}

