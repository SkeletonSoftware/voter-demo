using Voter.Core.Domains.Services.Vote.Questions;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;

namespace Voter.Web.Controllers.Vote.Questions.Create
{
    /// <summary>
    /// 
    /// Builder pro entitu - Otázky
    /// </summary>
    public class CreateQuestionHandler : IModelHandler<CreateQuestionModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly IQuestionService _QuestionService;

        public CreateQuestionHandler(ILoggedUser loggedUser, IQuestionService QuestionService)
        {
            _loggedUser = loggedUser;
            _QuestionService = QuestionService;
        }

        public ModelHandlerResult Handle(CreateQuestionModel model)
        {
            var data = new CreateQuestionModel();
            var result = _QuestionService.Create(new CreateQuestionInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID_Campaign = model.ID_Campaign,
                DisplayName = model.DisplayName,
                Description = model.Description,
                ID = model.Id,
            });

            return new ModelHandlerResult()
            {
                Message = result.IsSuccess ? Resources.Dictionary.Global_Create_SuccessNotification : null,
                Data = model,
                Exception = result.Exception,
                ValidationMessages = result.ValidationMessages
            };
        }
    }
}

