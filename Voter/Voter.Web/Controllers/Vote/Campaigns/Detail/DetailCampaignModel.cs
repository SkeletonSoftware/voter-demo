using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.Detail
{
    /// <summary>
    /// 
    /// Model builderu pro entitu - Kampaně
    /// </summary>
    public class DetailCampaignModel 
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
        /// Konstruktor - 
        /// Model builderu pro entitu - Kampaně
        /// </summary>
        public DetailCampaignModel()
        {
        }
    }
}

