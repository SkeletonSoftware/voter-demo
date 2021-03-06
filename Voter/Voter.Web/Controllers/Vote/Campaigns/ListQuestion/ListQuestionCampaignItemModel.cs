using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.ListQuestion
{
    /// <summary>
    /// Přehled otázek kampaně
    /// Model builderu pro entitu - Kampaně
    /// </summary>
    public class ListQuestionCampaignItemModel 
    {
        /// <summary>
        /// Jedinečné ID otázky
        /// </summary>
        [DisplayName("Jedinečné ID otázky")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Id { get; set; }

        /// <summary>
        /// Campaign
        /// </summary>
        [DisplayName("Campaign")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string Campaign { get; set; }

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

        /// <summary>
        /// Aktivní
        /// </summary>
        [DisplayName("Aktivní")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public bool IsActive { get; set; }

        /// <summary>
        /// Poznámka
        /// </summary>
        [DisplayName("Poznámka")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string Description { get; set; }

        /// <summary>
        /// Votes
        /// </summary>
        [DisplayName("Hlasů")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Votes { get; set; }

        /// <summary>
        /// DontKnow
        /// </summary>
        [DisplayName("Neví")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? DontKnow { get; set; }

        /// <summary>
        /// No
        /// </summary>
        [DisplayName("Ne")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? No { get; set; }

        /// <summary>
        /// Yes
        /// </summary>
        [DisplayName("Ano")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Yes { get; set; }

    }
}

