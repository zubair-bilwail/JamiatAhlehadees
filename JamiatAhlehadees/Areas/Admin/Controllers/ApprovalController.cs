using BusinessLogic.Implementation;
using BusinessLogic.Interface;
using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhlehadees.Areas.Admin.Controllers
{
    public class ApprovalController : Controller
    {
        private Approval _Approval;
        private readonly IApproval _ApprovalBusiness;
        public ApprovalController()
        {
            _Approval = new Approval();
            _ApprovalBusiness = new ApprovalBusiness();
        }

        // GET: Admin/Approval
        public ActionResult Index()
        {
            var _Approval = _ApprovalBusiness.ApprovalList().ToList();
            return View(_Approval);
        }
    }
}