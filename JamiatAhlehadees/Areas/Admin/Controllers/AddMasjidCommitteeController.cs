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
    public class AddMasjidCommitteeController : Controller
    {
        // GET: Admin/AddMasjidCommittee
        private AddMasjidCommittee _AddMasjidCommittee;
        private readonly IAddMasjidCommittee _AddMasjidCommitteeBusiness;
        public AddMasjidCommitteeController()
        {
            _AddMasjidCommittee = new AddMasjidCommittee();
            _AddMasjidCommitteeBusiness = new AddMasjidCommitteeBusiness();
        }
        // GET: Admin/AddMasjid
        public ActionResult Index()
        {
            var addMasjidCommittee = _AddMasjidCommitteeBusiness.MasjidCommitteeList();
            return View(addMasjidCommittee);
        }


        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                _AddMasjidCommittee = _AddMasjidCommitteeBusiness.GetById(Convert.ToInt32(id));
                _AddMasjidCommittee.AddMasjidList = _AddMasjidCommitteeBusiness.MasjidList();
                
            }
            else
            {
                _AddMasjidCommittee.AddMasjidCummitteList = _AddMasjidCommitteeBusiness.MasjidCommitteeList();
                _AddMasjidCommittee.AddMasjidList = _AddMasjidCommitteeBusiness.MasjidList();
              
            }
            return View(_AddMasjidCommittee);
        }
        [HttpPost]
        public ActionResult Create(AddMasjidCommittee model)
        {
            if (model != null)
            {
                _AddMasjidCommitteeBusiness.SaveMasjidCommittee(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            if (id != null && id != 0)
            {
                _AddMasjidCommittee = _AddMasjidCommitteeBusiness.GetById(id);
            }
            return View(_AddMasjidCommittee);
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                _AddMasjidCommittee.Id = Convert.ToInt32(id);
                _AddMasjidCommitteeBusiness.Delete(_AddMasjidCommittee);
            }

            return RedirectToAction("Index");
        }
    }
}