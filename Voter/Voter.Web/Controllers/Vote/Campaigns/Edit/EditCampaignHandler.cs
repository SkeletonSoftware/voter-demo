using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;

namespace Voter.Web.Controllers.Vote.Campaigns.Edit
{
    /// <summary>
    /// 
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class EditCampaignHandler : IModelHandler<EditCampaignModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;

        public EditCampaignHandler(ILoggedUser loggedUser, ICampaignService CampaignService)
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
        }

        public ModelHandlerResult Handle(EditCampaignModel model)
        {
            var data = new EditCampaignModel();
            var result = _CampaignService.Edit(new EditCampaignInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID = model.Id,
                DisplayName = model.DisplayName,
                Description = model.Description,
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

