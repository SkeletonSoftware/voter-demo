using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Campaigns.List
{
    /// <summary>
    /// 
    /// Model builderu pro entitu - Kampaně
    /// </summary>
    public class ListCampaignModel 
    {
        /// <summary>
        /// Položky
        /// </summary>
        public virtual ICollection<ListCampaignItemModel> Items { get; set; }

        /// <summary>
        /// Filtry
        /// </summary>
        public ListCampaignFilterModel Filter { get; set; }

        public ListCampaignModel()
        {
            Filter = new ListCampaignFilterModel();
            Items = new List<ListCampaignItemModel>();
        }
    }
}

