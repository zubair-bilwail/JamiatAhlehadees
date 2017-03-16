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
    public class NewMadarsaController : Controller
    {

        private NewMadarsaOperation _EMO_CoMo_Ctrller;
        private INewMadarsaOperation _EMO_Bs_Ctrller;
        private IApproval _ApprovalBusiness;
        public NewMadarsaController()
        {
            _EMO_CoMo_Ctrller = new NewMadarsaOperation();
            _EMO_Bs_Ctrller = new NewMadarsaOperationBusiness();
            _ApprovalBusiness = new ApprovalBusiness();
        }
        public ActionResult Index()
        {
            var varial = _EMO_Bs_Ctrller.NewMadarsaOperationList();
            return View(varial);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                _EMO_CoMo_Ctrller = _EMO_Bs_Ctrller.GetById(Convert.ToInt32(id));
                _EMO_CoMo_Ctrller.AddMadarsaCommitteeList = _EMO_Bs_Ctrller.AddMadarsaCommitteeList().ToList();
                _EMO_CoMo_Ctrller.UserList1 = _EMO_Bs_Ctrller.UserList().ToList();
                return View(_EMO_CoMo_Ctrller);

            }
            else
            {
                _EMO_CoMo_Ctrller.NewMadarsaOperationList = _EMO_Bs_Ctrller.NewMadarsaOperationList().ToList();
                _EMO_CoMo_Ctrller.AddMadarsaCommitteeList = _EMO_Bs_Ctrller.AddMadarsaCommitteeList().ToList();
                _EMO_CoMo_Ctrller.UserList1 = _EMO_Bs_Ctrller.UserList().ToList();
                return View(_EMO_CoMo_Ctrller);

            }

        }
        [HttpPost]
        public ActionResult Create(NewMadarsaOperation model)
        {
            if (model != null)
            {
                _EMO_Bs_Ctrller.Save(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {

                _EMO_CoMo_Ctrller.Id = Convert.ToInt32(id);
                _EMO_Bs_Ctrller.Delete(_EMO_CoMo_Ctrller);
            }

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (id != null && id != 0)
            {
                _EMO_CoMo_Ctrller = _EMO_Bs_Ctrller.GetById(id);

            }
            return View(_EMO_CoMo_Ctrller);
        }
        [HttpPost]
        public ActionResult Details(int id,string Comment,bool Status)
        {
            if (id != null)
            {
                _EMO_CoMo_Ctrller = _EMO_Bs_Ctrller.GetById(id);
                Approval _Approval = new Approval();
                _Approval.RequestId = _EMO_CoMo_Ctrller.Id;
                _Approval.RequestType = _EMO_CoMo_Ctrller.RequestId;
                _Approval.Comment = Comment;
                _Approval.Status = Status;
                _ApprovalBusiness.InsertApproval(_Approval);
            }
            return RedirectToAction("Index","Approval");
        }

    }
}