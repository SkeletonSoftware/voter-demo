using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Questions.List
{
    /// <summary>
    /// 
    /// Model builderu pro entitu - Otázky
    /// </summary>
    public class ListQuestionModel 
    {
        /// <summary>
        /// Položky
        /// </summary>
        public virtual ICollection<ListQuestionItemModel> Items { get; set; }

        /// <summary>
        /// Filtry
        /// </summary>
        public ListQuestionFilterModel Filter { get; set; }

        public ListQuestionModel()
        {
            Filter = new ListQuestionFilterModel();
            Items = new List<ListQuestionItemModel>();
        }
    }
}

