using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Questions.Create;
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
        public ActionResult Create(int ID_Campaign)
        {
            return AsView(Handler.Get<CreateQuestionBuilder>().Build(ID_Campaign));
        }

        /// <summary>
        /// 
        /// Pomocné volání kvůli validacím
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>View</returns>
        protected ActionResult CreateModel(CreateQuestionModel model)
        {
            return AsView(Handler.Get<CreateQuestionBuilder>().Build(model));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateQuestionModel model)
        {
            return AsView(Handler.Get<CreateQuestionHandler>().Handle(model), 
                RedirectToAction("Question", "Campaign", new { ID_Campaign = model.ID_Campaign }), CreateModel(model));
        }

    }
}

