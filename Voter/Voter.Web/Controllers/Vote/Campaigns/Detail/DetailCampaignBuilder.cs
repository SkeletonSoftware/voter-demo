using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Campaigns.Detail
{
    /// <summary>
    /// 
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class DetailCampaignBuilder : IModelBuilder<DetailCampaignModel, int>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;
        /*
        */

        public DetailCampaignBuilder(ILoggedUser loggedUser, ICampaignService CampaignService)
        /*
        */
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
            /*
            */
        }

        public ModelBuilderResult<DetailCampaignModel> Build(int id)
        {
            var data = new DetailCampaignModel();
            var result = _CampaignService.Detail(new DetailCampaignInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                ID = id,
            });

            data.Id = result.Data.ID;
            data.DisplayName = result.Data.DisplayName;
            data.Description = result.Data.Description;

            return Build(data);
        }

        public ModelBuilderResult<DetailCampaignModel> Build(DetailCampaignModel model)
        {
            /*

            */
            return this.Success(model);
        }
    }
}

