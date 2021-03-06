using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Campaigns.Edit;
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
        /// <param name="id">Id</param>
        /// <returns>View</returns>
        public ActionResult Edit(int id)
        {
            return AsView(Handler.Get<EditCampaignBuilder>().Build(id));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditCampaignModel model)
        {
            return AsView(Handler.Get<EditCampaignHandler>().Handle(model), RedirectToAction("Edit", "Campaign", new { id = model.Id }));
        }

    }
}

