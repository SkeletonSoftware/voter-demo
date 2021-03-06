using Voter.Core.Domains.Services.Vote.Questions;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Questions.Edit
{
    /// <summary>
    /// 
    /// Builder pro entitu - Otázky
    /// </summary>
    public class EditQuestionBuilder : IModelBuilder<EditQuestionModel, int>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly IQuestionService _QuestionService;
        /*
        */

        public EditQuestionBuilder(ILoggedUser loggedUser, IQuestionService QuestionService)
        /*
        */
        {
            _loggedUser = loggedUser;
            _QuestionService = QuestionService;
            /*
            */
        }

        public ModelBuilderResult<EditQuestionModel> Build(int id)
        {
            var data = new EditQuestionModel();
            var result = _QuestionService.Detail(new DetailQuestionInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID = id,
            });

            data.Id = result.Data.ID;
            data.DisplayName = result.Data.DisplayName;
            data.Description = result.Data.Description;

            return Build(data);
        }

        public ModelBuilderResult<EditQuestionModel> Build(EditQuestionModel model)
        {
            /*

            */
            return this.Success(model);
        }
    }
}

