using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Campaigns.Create;
using Voter.Web.Mvc.Common;
using System.Web.Mvc;

namespace Voter.Web.Controllers.Vote.Campaigns
{
    /// <summary>
    /// Implementace kontroleru pro entitu - Kampaně
    /// </summary>
    public partial class CampaignController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Create()
        {
            return AsView(Handler.Get<CreateCampaignBuilder>().Build());
        }

        /// <summary>
        /// 
        /// Pomocné volání kvůli validacím
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>View</returns>
        protected ActionResult CreateModel(CreateCampaignModel model)
        {
            return AsView(Handler.Get<CreateCampaignBuilder>().Build(model));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCampaignModel model)
        {
            return AsView(Handler.Get<CreateCampaignHandler>().Handle(model), RedirectToAction("Index", "Campaign"), CreateModel(model));
        }

    }
}

