using Voter.Core.Domains.Services.Vote.Questions;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Questions.Detail
{
    /// <summary>
    /// 
    /// Builder pro entitu - Otázky
    /// </summary>
    public class DetailQuestionBuilder : IModelBuilder<DetailQuestionModel, int>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly IQuestionService _QuestionService;
        /*
        */

        public DetailQuestionBuilder(ILoggedUser loggedUser, IQuestionService QuestionService)
        /*
        */
        {
            _loggedUser = loggedUser;
            _QuestionService = QuestionService;
            /*
            */
        }

        public ModelBuilderResult<DetailQuestionModel> Build(int id)
        {
            var data = new DetailQuestionModel();
            var result = _QuestionService.Detail(new DetailQuestionInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID = id,
            });

            data.Id = result.Data.ID;
            data.Campaign = result.Data.Campaign;
            data.ID_Campaign = result.Data.ID_Campaign;
            data.DisplayName = result.Data.DisplayName;
            data.IsActive = result.Data.IsActive;
            data.Description = result.Data.Description;

            return Build(data);
        }

        public ModelBuilderResult<DetailQuestionModel> Build(DetailQuestionModel model)
        {
            /*

            */
            return this.Success(model);
        }
    }
}

