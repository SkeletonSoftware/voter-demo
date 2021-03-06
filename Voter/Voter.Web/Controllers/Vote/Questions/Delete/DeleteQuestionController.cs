using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Questions.Delete;
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
        /// <returns>View</returns>
        public ActionResult Delete(int id)
        {
            return AsView(Handler.Get<DeleteQuestionHandler>().Handle(id), RedirectToAction("Index", "Question"));
        }

    }
}

