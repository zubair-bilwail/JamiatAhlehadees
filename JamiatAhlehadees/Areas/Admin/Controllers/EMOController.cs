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
    public class EMOController : Controller
    {
        private readonly ExistingMadarsaOperations _EMO_CoMo_Ctrller;
        private readonly IExistingMadarsaOperations _EMO_Bs_Ctrller;
        public EMOController()
        {
            _EMO_CoMo_Ctrller = new ExistingMadarsaOperations();
            _EMO_Bs_Ctrller = new ExistingMadarsaOperationsBusiness();
        }
        public ActionResult Index()
        {
            var varial = _EMO_Bs_Ctrller._ExistingMadarsaOperarionList();
            return View(varial);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var varial = _EMO_Bs_Ctrller.GetById(Convert.ToInt32(id));
                varial._AddMadarsaCommitteeList = _EMO_Bs_Ctrller._AddMadarsaCommitteeList().ToList();
                return View(varial);
              
            }
            else
            {
                _EMO_CoMo_Ctrller._ExistingMadarsaOperarionList = _EMO_Bs_Ctrller._ExistingMadarsaOperarionList().ToList();
                _EMO_CoMo_Ctrller._AddMadarsaCommitteeList = _EMO_Bs_Ctrller._AddMadarsaCommitteeList().ToList();
                return View(_EMO_CoMo_Ctrller);

            }

        }
        [HttpPost]
        public ActionResult Create(ExistingMadarsaOperations model)
        {
            if (model != null)
            {
                _EMO_Bs_Ctrller.Save_EMO(model);
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
    }
}