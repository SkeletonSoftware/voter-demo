using Voter.Core.Domains.Services.Vote.Questions;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Questions.List
{
    /// <summary>
    /// 
    /// Builder pro entitu - Otázky
    /// </summary>
    public class ListQuestionBuilder : IModelBuilder<ListQuestionModel, ListQuestionFilterModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly IQuestionService _QuestionService;

        public ListQuestionBuilder(ILoggedUser loggedUser, IQuestionService QuestionService)
        {
            _loggedUser = loggedUser;
            _QuestionService = QuestionService;
        }

        public ModelBuilderResult<ListQuestionModel> Build(ListQuestionFilterModel filter)
        {
            var data = new ListQuestionModel();
            var result = _QuestionService.List(new ListQuestionInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                Top = filter.Top,
                ID = filter.Id,
                ID_Campaign = filter.ID_Campaign,
                DisplayName = filter.DisplayName,
            });
            data.Items = result.Data.Select(x => new ListQuestionItemModel
            {
                Id = x.ID,
                Campaign = x.Campaign,
                ID_Campaign = x.ID_Campaign,
                DisplayName = x.DisplayName,
                IsActive = x.IsActive,
                Description = x.Description,
            }).ToList();

            return this.Success(data);
        }
    }
}

