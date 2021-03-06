using System;

namespace Voter.Core.Domains.Services.Vote.Questions
{
    /// <summary>
    /// 
    /// Výstupní model entity - Otázky
    /// </summary>
    public class ListQuestionOutputModel 
    {
        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        public int? ID { get; set; }

        /// <summary>
        /// Campaign
        /// </summary>
        public string Campaign { get; set; }

        /// <summary>
        /// ID_Campaign
        /// </summary>
        public int? ID_Campaign { get; set; }

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

