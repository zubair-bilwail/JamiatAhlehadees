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
    public class MasjidRenovationController : Controller
    {
         private readonly MasjidRenovation _CoMo_Ctrller;
        private readonly IMasjidRenovation _Bs_Ctrller;
        public MasjidRenovationController()
        {
            _CoMo_Ctrller = new MasjidRenovation();
            _Bs_Ctrller = new MasjidRenovationBusiness();
        }
        public ActionResult Index()
        {
            var varial = _Bs_Ctrller.MasjidRenovationList();
            return View(varial);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var varial = _Bs_Ctrller.GetById(Convert.ToInt32(id));
                varial.AddMasjidList = _Bs_Ctrller.AddMasjidList().ToList();
                varial.UserList = _Bs_Ctrller.UserList().ToList();
                return View(varial);
              
            }
            else
            {
                _CoMo_Ctrller.MasjidRenovationList = _Bs_Ctrller.MasjidRenovationList().ToList();
                _CoMo_Ctrller.AddMasjidList = _Bs_Ctrller.AddMasjidList().ToList();
                _CoMo_Ctrller.UserList = _Bs_Ctrller.UserList().ToList();
                return View(_CoMo_Ctrller);

            }

        }
        [HttpPost]
        public ActionResult Create(MasjidRenovation model)
        {
            if (model != null)
            {
                _Bs_Ctrller.SaveMasjidRenovation(model);
                
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {

                _CoMo_Ctrller.Id = Convert.ToInt32(id);
                _Bs_Ctrller.Delete(_CoMo_Ctrller);
            }

            return RedirectToAction("Index");
        }
    }
}