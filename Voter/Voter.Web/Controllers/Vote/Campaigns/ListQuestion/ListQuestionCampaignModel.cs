using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.ListQuestion
{
    /// <summary>
    /// Přehled otázek kampaně
    /// Model builderu pro entitu - Kampaně
    /// </summary>
    public class ListQuestionCampaignModel 
    {
        /// <summary>
        /// Položky
        /// </summary>
        public virtual ICollection<ListQuestionCampaignItemModel> Items { get; set; }

        /// <summary>
        /// Filtry
        /// </summary>
        public ListQuestionCampaignFilterModel Filter { get; set; }

        public ListQuestionCampaignModel()
        {
            Filter = new ListQuestionCampaignFilterModel();
            Items = new List<ListQuestionCampaignItemModel>();
        }
    }
}

