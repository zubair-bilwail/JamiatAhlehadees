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
    public class AddHalqaController : Controller
    {
        private AddHalqa _AddHalqa;
        private readonly IAddHalqa _AddHalqaBusiness;
        public AddHalqaController()
        {
            _AddHalqa = new AddHalqa();
            _AddHalqaBusiness = new AddHalqaBusiness();
        }
        // GET: Admin/AddHalqa
        public ActionResult Index()
        {
            var AddHalqa = _AddHalqaBusiness.HalqaList();
            return View(AddHalqa);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {
               var _AddHalqa = _AddHalqaBusiness.GetById(Convert.ToInt32(id));
                return View(_AddHalqa);
                //_AddHalqa.AddHalqaList = _AddHalqaBusiness.HalqaList().ToList();
            }
            else
            {
                _AddHalqa.AddHalqaList = _AddHalqaBusiness.HalqaList().ToList();
                return View(_AddHalqa);

            }
            
        }
        [HttpPost]
        public ActionResult Create(AddHalqa model)
        {
            if (model != null)
            {
                _AddHalqaBusiness.SaveHalqa(model);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (id != null && id != 0)
            {
                _AddHalqa = _AddHalqaBusiness.GetById(id);
            }
            return View(_AddHalqa);
        }
        public ActionResult Delete(int id)
        {
            if (id != null && id != 0)
            {
                _AddHalqa = _AddHalqaBusiness.GetById(id);
                _AddHalqaBusiness.Delete(_AddHalqa);
            }
            
            return RedirectToAction("Index");
        }
    }
}