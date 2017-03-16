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
    public class AddMasjidController : Controller
    {

        private AddMasjid _AddMasjid;
        private readonly IAddMasjid _AddMasjidBusiness;
        public AddMasjidController()
        {
            _AddMasjid = new AddMasjid();
            _AddMasjidBusiness = new AddMasjidBusiness();
        }
        // GET: Admin/AddMasjid
        public ActionResult Index()
        {
            var addMasjid = _AddMasjidBusiness.MasjidList(); 
            return View(addMasjid);
        }


        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                _AddMasjid = _AddMasjidBusiness.GetById(Convert.ToInt32(id));
                _AddMasjid.AddHalqaList = _AddMasjidBusiness.HalqaList().ToList();
                _AddMasjid.UserList = _AddMasjidBusiness.UserList().ToList();
            }
            else
            {
                _AddMasjid.AddMasjidList = _AddMasjidBusiness.MasjidList().ToList();
                _AddMasjid.AddHalqaList = _AddMasjidBusiness.HalqaList().ToList();
                _AddMasjid.UserList = _AddMasjidBusiness.UserList().ToList();
            }
            return View(_AddMasjid);
        }
        [HttpPost]
        public ActionResult Create(AddMasjid model)
        {
            if (model != null)
            {
                _AddMasjidBusiness.SaveMasjid(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            if (id != null && id != 0)
            {
                _AddMasjid = _AddMasjidBusiness.GetById(id);
            }
            return View(_AddMasjid);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                _AddMasjid.Id = Convert.ToInt32(id);
                _AddMasjidBusiness.Delete(_AddMasjid);
            }

            return RedirectToAction("Index");
        }

    }
}
