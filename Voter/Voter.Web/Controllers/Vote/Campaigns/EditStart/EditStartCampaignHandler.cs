using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;

namespace Voter.Web.Controllers.Vote.Campaigns.EditStart
{
    /// <summary>
    /// 
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class EditStartCampaignHandler : IModelHandler<EditStartCampaignModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;

        public EditStartCampaignHandler(ILoggedUser loggedUser, ICampaignService CampaignService)
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
        }

        public ModelHandlerResult Handle(EditStartCampaignModel model)
        {
            var data = new EditStartCampaignModel();
            var result = _CampaignService.EditStart(new EditStartCampaignInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID = model.Id,
            });

            return new ModelHandlerResult()
            {
                Message = result.IsSuccess ? Resources.Dictionary.Global_Edit_SuccessNotification : null,
                Data = model,
                Exception = result.Exception,
                ValidationMessages = result.ValidationMessages
            };
        }
    }
}

