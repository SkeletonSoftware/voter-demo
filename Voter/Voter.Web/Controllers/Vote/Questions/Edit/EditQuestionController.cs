using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Questions.Edit;
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
        public ActionResult Edit(int id)
        {
            return AsView(Handler.Get<EditQuestionBuilder>().Build(id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditQuestionModel model)
        {
            return AsView(Handler.Get<EditQuestionHandler>().Handle(model), RedirectToAction("Edit", "Question", new { id = model.Id }));
        }

    }
}

