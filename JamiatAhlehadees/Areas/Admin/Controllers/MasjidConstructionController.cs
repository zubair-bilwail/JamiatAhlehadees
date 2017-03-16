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
    public class MasjidConstructionController : Controller
    {
        private readonly MasjidConstruction _masjidcon_CoMo_Ctrller;
        private readonly IMasjidConstruction _masjidcon_Bs_Ctrller;
        public MasjidConstructionController()
        {
            _masjidcon_CoMo_Ctrller = new MasjidConstruction();
            _masjidcon_Bs_Ctrller = new MasjidConstructionBusiness();
        }
        public ActionResult Index()
        {
            var varial = _masjidcon_Bs_Ctrller.MasjidConstructionList();
            return View(varial);
        }
        public ActionResult Create(int? id)
        {
            if (id != null)
            {


                var varial = _masjidcon_Bs_Ctrller.GetById(Convert.ToInt32(id));
                varial.UserList = _masjidcon_Bs_Ctrller.UserList().ToList();
                return View(varial);
              
            }
            else
            {
                _masjidcon_CoMo_Ctrller.MasjidConstructionList = _masjidcon_Bs_Ctrller.MasjidConstructionList().ToList();
                _masjidcon_CoMo_Ctrller.UserList = _masjidcon_Bs_Ctrller.UserList().ToList();
              
                return View(_masjidcon_CoMo_Ctrller);

            }

        }
        [HttpPost]
        public ActionResult Create(MasjidConstruction model)
        {
            if (model != null)
            {
                _masjidcon_Bs_Ctrller.SaveMasjidConstruction(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                
                _masjidcon_CoMo_Ctrller.Id = Convert.ToInt32(id);
                _masjidcon_Bs_Ctrller.Delete(_masjidcon_CoMo_Ctrller);
            }

            return RedirectToAction("Index");
        }
    }
}