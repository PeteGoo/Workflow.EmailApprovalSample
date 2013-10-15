using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Approval.Web.Controllers {
    public class ApprovalController : Controller {

        public ActionResult Approve(string id) {
            ApprovalWorkflowService.ServiceClient serviceClient = new ApprovalWorkflowService.ServiceClient();
            serviceClient.Approve(id);
            return View();
        }

        public ActionResult Decline(string id) {
            ApprovalWorkflowService.ServiceClient serviceClient = new ApprovalWorkflowService.ServiceClient();
            serviceClient.Decline(id);
            return View();
        }

    }
}
