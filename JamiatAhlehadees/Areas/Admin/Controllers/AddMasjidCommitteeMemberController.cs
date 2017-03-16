using BusinessLogic.Implementation;
using CommonLayer.CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamiatAhlehadees.Areas.Admin.Controllers
{
    public class AddMasjidCommitteeMemberController : Controller
    {
        private AddMasjidCommitteeMember _AddMasjidCommitteeMember;
        private AddMasjidCommitteeMembersBusiness _AddMasjidCommitteeMembersBusiness;
        public AddMasjidCommitteeMemberController()
        {
            _AddMasjidCommitteeMember = new AddMasjidCommitteeMember();
            _AddMasjidCommitteeMembersBusiness = new AddMasjidCommitteeMembersBusiness();
        }
        // GET: Admin/AddMasjidCommitteeMember
        public ActionResult Index()
        {
            var _AddMasjidCommitteeMember = _AddMasjidCommitteeMembersBusiness.MasjidCommitteeMemberList();
            return View(_AddMasjidCommitteeMember);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var _AddMasjidCommitteeMember = _AddMasjidCommitteeMembersBusiness.GetById(Convert.ToInt32(id));
                _AddMasjidCommitteeMember.AddMasjidCommitteeList = _AddMasjidCommitteeMembersBusiness.MasjidCommitteeList();
                _AddMasjidCommitteeMember.UserList = _AddMasjidCommitteeMembersBusiness.UserList();
                return View(_AddMasjidCommitteeMember);

            }
            else
            {
                _AddMasjidCommitteeMember.AddMasjidCommitteeMemberList = _AddMasjidCommitteeMembersBusiness.MasjidCommitteeMemberList();
                _AddMasjidCommitteeMember.AddMasjidCommitteeList = _AddMasjidCommitteeMembersBusiness.MasjidCommitteeList();
                _AddMasjidCommitteeMember.UserList = _AddMasjidCommitteeMembersBusiness.UserList();
                return View(_AddMasjidCommitteeMember);

            }

        }
        [HttpPost]
        public ActionResult Create(AddMasjidCommitteeMember model)
        {
            if (model != null)
            {
                _AddMasjidCommitteeMembersBusiness.SaveMasjidCommitteeMember(model);
            }
            return RedirectToAction("Index");
        }

    }
}