using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Campaigns.Delete;
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
        public ActionResult Delete(int id)
        {
            return AsView(Handler.Get<DeleteCampaignHandler>().Handle(id), RedirectToAction("Index", "Campaign"));
        }

    }
}

