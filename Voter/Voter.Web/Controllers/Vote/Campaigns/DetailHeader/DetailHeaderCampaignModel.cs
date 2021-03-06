using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.DetailHeader
{
    /// <summary>
    /// 
    /// Model builderu pro entitu - Kampaně
    /// </summary>
    public class DetailHeaderCampaignModel 
    {
        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        [DisplayName("Jedinečné ID kampaně")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Id { get; set; }

        /// <summary>
        /// Název
        /// </summary>
        [DisplayName("Název")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string DisplayName { get; set; }

        /// <summary>
        /// Poznámka
        /// </summary>
        [DisplayName("Poznámka")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string Description { get; set; }

        /// <summary>
        /// Question
        /// </summary>
        [DisplayName("Question")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string Question { get; set; }

        /// <summary>
        /// Otázka
        /// </summary>
        [DisplayName("Otázka")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name.SubString(3)), ResourceType = typeof(Resources.Dictionary))]
        public int? ID_Question { get; set; }

        /// <summary>
        /// Konstruktor - 
        /// Model builderu pro entitu - Kampaně
        /// </summary>
        public DetailHeaderCampaignModel()
        {
        }
    }
}

