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
    [AllowAnonymous]
    public class AddMadarsaController : Controller
    {
        // GET: Admin/AddMadarsa
        private AddMadarsa _AddMadarsa;
        private readonly IAddMadarsa _AddMadarsaBusiness;
        public AddMadarsaController()
        {
            _AddMadarsa = new AddMadarsa();
            _AddMadarsaBusiness = new AddMadarsaBusiness();
        }
        // GET: Admin/AddHalqa
        public ActionResult Index()
        {
            var addMadarsa = _AddMadarsaBusiness.MadarsaList();
            return View(addMadarsa);
        }
        [Authorize(Roles = "A,U")]
        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                _AddMadarsa = _AddMadarsaBusiness.GetById(Convert.ToInt32(id));
                _AddMadarsa.AddHAlqaList = _AddMadarsaBusiness.HalqaList().ToList();
                _AddMadarsa.UserList = _AddMadarsaBusiness.UserList().ToList();

                //_AddHalqa.AddHalqaList = _AddHalqaBusiness.HalqaList().ToList();
            }
            else
            {
                _AddMadarsa.AddMadarsaList = _AddMadarsaBusiness.MadarsaList().ToList();
                _AddMadarsa.AddHAlqaList = _AddMadarsaBusiness.HalqaList().ToList();
                _AddMadarsa.UserList = _AddMadarsaBusiness.UserList().ToList();
            }
            return View(_AddMadarsa);
        }
        [HttpPost]
        public ActionResult Create(AddMadarsa model)
        {
            if (model != null)
            {

                _AddMadarsaBusiness.SaveMadarsa(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                _AddMadarsa.Id = Convert.ToInt32(id);
                _AddMadarsaBusiness.Delete(_AddMadarsa);
            }

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (id != null && id != 0)
            {
                _AddMadarsa = _AddMadarsaBusiness.GetById(id);
            }
            return View(_AddMadarsa);
        }
    }
}