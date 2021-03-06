using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.Delete
{
    /// <summary>
    /// 
    /// Model builderu pro entitu - Kampaně
    /// </summary>
    public class DeleteCampaignModel 
    {
        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        [DisplayName("Jedinečné ID kampaně")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Campaigns_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Id { get; set; }

        /// <summary>
        /// Konstruktor - 
        /// Model builderu pro entitu - Kampaně
        /// </summary>
        public DeleteCampaignModel()
        {
        }
    }
}

