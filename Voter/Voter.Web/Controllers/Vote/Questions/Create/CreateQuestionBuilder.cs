using Voter.Core.Domains.Services.Vote.Questions;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Questions.Create
{
    /// <summary>
    /// 
    /// Builder pro entitu - Otázky
    /// </summary>
    public class CreateQuestionBuilder : IModelBuilder<CreateQuestionModel, int>, IModelBuilder<CreateQuestionModel, CreateQuestionModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly IQuestionService _QuestionService;
        /*
        */

        public CreateQuestionBuilder(ILoggedUser loggedUser, IQuestionService QuestionService)
        /*
        */
        {
            _loggedUser = loggedUser;
            _QuestionService = QuestionService;
            /*
            */
        }

        public ModelBuilderResult<CreateQuestionModel> Build(int id)
        {
            var data = new CreateQuestionModel();
            data.ID_Campaign = id;

            return this.Build(data);
        }

        public ModelBuilderResult<CreateQuestionModel> Build(CreateQuestionModel model)
        {
            /*

            */
            return this.Success(model);
        }
    }
}

