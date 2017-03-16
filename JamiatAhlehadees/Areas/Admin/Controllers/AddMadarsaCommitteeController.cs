using CommonLayer.CommonModels;
using BusinessLogic.Interface;
using BusinessLogic.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhlehadees.Areas.Admin.Controllers
{
    public class AddMadarsaCommitteeController : Controller
    {
        private AddMadarsaCommittee _AddMadarsaCommittee;
        private readonly IAddMadarsaCommittee _AddMadarsaCommitteeBusiness;
        public AddMadarsaCommitteeController()
        {
            _AddMadarsaCommittee = new AddMadarsaCommittee();
            _AddMadarsaCommitteeBusiness = new AddMadarsaCommitteeBusiness();
        }
        // GET: Admin/AddMadarsaCommittee
        public ActionResult Index()
        {
            var _AddCommittee = _AddMadarsaCommitteeBusiness.MadarsaCommitteeList().ToList();
            return View(_AddCommittee);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var _AddMadarsaCommittee = _AddMadarsaCommitteeBusiness.GetById(Convert.ToInt32(id));
                _AddMadarsaCommittee.AddMadarsaList = _AddMadarsaCommitteeBusiness.MadarsaList().ToList();
                return View(_AddMadarsaCommittee);
                //_AddHalqa.AddHalqaList = _AddHalqaBusiness.HalqaList().ToList();
            }
            else
            {
                _AddMadarsaCommittee.AddMadarsaList = _AddMadarsaCommitteeBusiness.MadarsaList().ToList();
                _AddMadarsaCommittee.AddMadarsaCommitteeList = _AddMadarsaCommitteeBusiness.MadarsaCommitteeList().ToList();
                return View(_AddMadarsaCommittee);

            }

        }
        [HttpPost]
        public ActionResult Create(AddMadarsaCommittee model)
        {
            if (model != null)
            {
                _AddMadarsaCommitteeBusiness.SaveMadarsaCommittee(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                _AddMadarsaCommittee.Id = Convert.ToInt32(id);
                _AddMadarsaCommitteeBusiness.Delete(_AddMadarsaCommittee);
            }

            return RedirectToAction("Index");
        }
    }
}