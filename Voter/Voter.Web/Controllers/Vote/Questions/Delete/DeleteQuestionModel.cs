using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Questions.Delete
{
    /// <summary>
    /// 
    /// Model builderu pro entitu - Otázky
    /// </summary>
    public class DeleteQuestionModel 
    {
        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        [DisplayName("Jedinečné ID kampaně")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Questions_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Id { get; set; }

        /// <summary>
        /// Konstruktor - 
        /// Model builderu pro entitu - Otázky
        /// </summary>
        public DeleteQuestionModel()
        {
        }
    }
}

