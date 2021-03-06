using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Campaigns.Create
{
    /// <summary>
    /// 
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class CreateCampaignBuilder : IModelBuilder<CreateCampaignModel>, IModelBuilder<CreateCampaignModel, CreateCampaignModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;
        /*
        */

        public CreateCampaignBuilder(ILoggedUser loggedUser, ICampaignService CampaignService)
        /*
        */
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
            /*
            */
        }

        public ModelBuilderResult<CreateCampaignModel> Build()
        {
            var data = new CreateCampaignModel();

            return this.Build(data);
        }

        public ModelBuilderResult<CreateCampaignModel> Build(CreateCampaignModel model)
        {
            /*

            */
            return this.Success(model);
        }
    }
}

