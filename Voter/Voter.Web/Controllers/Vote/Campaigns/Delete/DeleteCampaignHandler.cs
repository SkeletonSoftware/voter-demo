using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;

namespace Voter.Web.Controllers.Vote.Campaigns.Delete
{
    /// <summary>
    /// 
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class DeleteCampaignHandler : IModelHandler<int>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;

        public DeleteCampaignHandler(ILoggedUser loggedUser, ICampaignService CampaignService)
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
        }

        public ModelHandlerResult Handle(int id)
        {
            var data = new DeleteCampaignModel();
            var result = _CampaignService.Delete(new DeleteCampaignInputModel
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

