using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Campaigns.EditNext;
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
        public ActionResult EditNext(EditNextCampaignModel model)
        {
            return AsView(Handler.Get<EditNextCampaignHandler>().Handle(model), RedirectToAction("Index", "Vote", new { ID_Campaign = model.Id }));
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns>View</returns>
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditNext(EditNextCampaignModel model)
        //{
        //    return AsView(Handler.Get<EditNextCampaignHandler>().Handle(model), RedirectToAction("Edit", "Campaign", new { id = model.Id }));
        //}

    }
}

