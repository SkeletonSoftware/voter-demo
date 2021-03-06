using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.ListQuestion
{
    /// <summary>
    /// Přehled otázek kampaně
    /// Vstupní model entity - Kampaně
    /// </summary>
    public class ListQuestionCampaignFilterModel 
    {
        /// <summary>
        /// Top
        /// </summary>
        [DisplayName("Top")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Top { get; set; }

        /// <summary>
        /// Jedinečné ID otázky
        /// </summary>
        [DisplayName("Jedinečné ID otázky")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Id { get; set; }

        /// <summary>
        /// Kampaň
        /// </summary>
        [DisplayName("Kampaň")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name.SubString(3)), ResourceType = typeof(Resources.Dictionary))]
        public int? ID_Campaign { get; set; }

        /// <summary>
        /// Název
        /// </summary>
        [DisplayName("Název")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string DisplayName { get; set; }

    }
}

