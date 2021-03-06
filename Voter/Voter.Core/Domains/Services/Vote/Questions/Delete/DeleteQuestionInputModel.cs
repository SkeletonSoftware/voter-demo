using System;

namespace Voter.Core.Domains.Services.Vote.Questions
{
    /// <summary>
    /// 
    /// Vstupní model entity - Otázky
    /// </summary>
    public class DeleteQuestionInputModel 
    {
        /// <summary>
        /// ID_Login
        /// </summary>
        public Guid ID_Login { get; set; }

        /// <summary>
        /// Jedinečné ID kampaně
        /// </summary>
        public int? ID { get; set; }

    }
}

