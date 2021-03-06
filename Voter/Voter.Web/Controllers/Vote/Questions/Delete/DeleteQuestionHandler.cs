using Voter.Core.Domains.Services.Vote.Questions;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;

namespace Voter.Web.Controllers.Vote.Questions.Delete
{
    /// <summary>
    /// 
    /// Builder pro entitu - Otázky
    /// </summary>
    public class DeleteQuestionHandler : IModelHandler<int>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly IQuestionService _QuestionService;

        public DeleteQuestionHandler(ILoggedUser loggedUser, IQuestionService QuestionService)
        {
            _loggedUser = loggedUser;
            _QuestionService = QuestionService;
        }

        public ModelHandlerResult Handle(int id)
        {
            var data = new DeleteQuestionModel();
            var result = _QuestionService.Delete(new DeleteQuestionInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID = id,
            });

            return new ModelHandlerResult()
            {
                Message = result.IsSuccess ? Resources.Dictionary.Global_Delete_SuccessNotification : null,
                Data = result.Data,
                Exception = result.Exception,
                ValidationMessages = result.ValidationMessages
            };
        }
    }
}

