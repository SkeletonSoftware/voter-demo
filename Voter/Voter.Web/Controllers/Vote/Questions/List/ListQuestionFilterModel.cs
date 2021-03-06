using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Voter.Web.Controllers.Vote.Questions.List
{
    /// <summary>
    /// 
    /// Vstupní model entity - Otázky
    /// </summary>
    public class ListQuestionFilterModel 
    {
        /// <summary>
        /// Top
        /// </summary>
        [DisplayName("Top")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Questions_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Top { get; set; }

        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        [DisplayName("Jedinečné ID kampaně")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Questions_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public int? Id { get; set; }

        /// <summary>
        /// ID_Campaign
        /// </summary>
        [DisplayName("ID_Campaign")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Questions_$column.Value.Name.SubString(3)), ResourceType = typeof(Resources.Dictionary))]
        public int? ID_Campaign { get; set; }

        /// <summary>
        /// Název
        /// </summary>
        [DisplayName("Název")]
        //[Display(Name = nameof(Resources.Dictionary.Vote_Questions_$column.Value.Name), ResourceType = typeof(Resources.Dictionary))]
        public string DisplayName { get; set; }

    }
}

