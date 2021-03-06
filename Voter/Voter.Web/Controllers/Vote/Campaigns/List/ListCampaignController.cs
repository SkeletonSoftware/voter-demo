using Voter.Web.Controllers.Common;
using Voter.Web.Controllers.Vote.Campaigns.List;
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
        /// <param name="model">filtr</param>
        /// <returns>View</returns>
        public ActionResult Index(ListCampaignFilterModel model)
        {
            return AsView(Handler.Get<ListCampaignBuilder>().Build(model));
        }
    }
}

