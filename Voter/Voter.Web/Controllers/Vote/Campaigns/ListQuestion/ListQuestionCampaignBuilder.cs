using Voter.Core.Domains.Services.Vote.Campaigns;
using Voter.Web.Mvc.LoggedUsers;
using Voter.Web.Mvc.Results;
using System;
using System.Linq;

namespace Voter.Web.Controllers.Vote.Campaigns.ListQuestion
{
    /// <summary>
    /// Přehled otázek kampaně
    /// Builder pro entitu - Kampaně
    /// </summary>
    public class ListQuestionCampaignBuilder : IModelBuilder<ListQuestionCampaignModel, ListQuestionCampaignFilterModel>
    {
        private readonly ILoggedUser _loggedUser;
        private readonly ICampaignService _CampaignService;

        public ListQuestionCampaignBuilder(ILoggedUser loggedUser, ICampaignService CampaignService)
        {
            _loggedUser = loggedUser;
            _CampaignService = CampaignService;
        }

        public ModelBuilderResult<ListQuestionCampaignModel> Build(ListQuestionCampaignFilterModel filter)
        {
            var data = new ListQuestionCampaignModel();
            var result = _CampaignService.ListQuestion(new ListQuestionCampaignInputModel
            {
                ID_Login = _loggedUser.ID_Login,
                Top = filter.Top,
                ID = filter.Id,
                ID_Campaign = filter.ID_Campaign,
                DisplayName = filter.DisplayName,
            });
            data.Items = result.Data.Select(x => new ListQuestionCampaignItemModel
            {
                Id = x.ID,
                Campaign = x.Campaign,
                ID_Campaign = x.ID_Campaign,
                DisplayName = x.DisplayName,
                IsActive = x.IsActive,
                Description = x.Description,
                Votes = x.Votes,
                DontKnow = x.DontKnow,
                No = x.No,
                Yes = x.Yes,
            }).ToList();

            return this.Success(data);
        }
    }
}

