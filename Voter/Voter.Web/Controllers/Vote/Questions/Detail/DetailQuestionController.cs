using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Questions.Detail;
using Voter.Web.Mvc.Common;
using System.Web.Mvc;

namespace Voter.Web.Controllers.Vote.Questions
{
    /// <summary>
    /// Implementace kontroleru pro entitu - Otázky
    /// </summary>
    public partial class QuestionController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>View</returns>
        public ActionResult Detail(int id)
        {
            return AsView(Handler.Get<DetailQuestionBuilder>().Build(id));
        }

    }
}

