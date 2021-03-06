using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;

namespace Voter.Web.Controllers.Vote.Campaigns.Create
{
    /// <summary>
    /// 
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class CreateCampaignHandler : IModelHandler<CreateCampaignModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;

        public CreateCampaignHandler(ILoggedUser loggedUser, ICampaignService CampaignService)
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
        }

        public ModelHandlerResult Handle(CreateCampaignModel model)
        {
            var data = new CreateCampaignModel();
            var result = _CampaignService.Create(new CreateCampaignInputModel
            {
                ID_Login = _loggedUser.ID_Login,
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

