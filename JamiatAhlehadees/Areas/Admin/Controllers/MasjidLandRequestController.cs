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
    public class MasjidLandRequestController : Controller
    {
        private readonly MasjidLandRequest _MasjidLandRequest;
        private readonly IMasjidLandRequest _MasjidLandRequestBusiness;
        public MasjidLandRequestController()
        {
            _MasjidLandRequest = new MasjidLandRequest();
            _MasjidLandRequestBusiness = new MasjidLandRequestBusiness();
        }
        // GET: Admin/AddHalqa
        public ActionResult Index()
        {
            var masjidLandRequest = _MasjidLandRequestBusiness.LandRequestList();
            return View(masjidLandRequest);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var _MasjidLandRequest = _MasjidLandRequestBusiness.GetById(Convert.ToInt32(id));
                _MasjidLandRequest.AddMasjidCommitteeList = _MasjidLandRequestBusiness.MasjidCommitteeList();
                _MasjidLandRequest.AddMasjidList = _MasjidLandRequestBusiness.MasjidList();
                _MasjidLandRequest.UserList = _MasjidLandRequestBusiness.UserList();
                return View(_MasjidLandRequest);
            }
            else
            {
                _MasjidLandRequest.MasjidLandRequestList = _MasjidLandRequestBusiness.LandRequestList().ToList();
                _MasjidLandRequest.AddMasjidCommitteeList = _MasjidLandRequestBusiness.MasjidCommitteeList();
                _MasjidLandRequest.AddMasjidList = _MasjidLandRequestBusiness.MasjidList();
                _MasjidLandRequest.UserList = _MasjidLandRequestBusiness.UserList();
                return View(_MasjidLandRequest);
            }
        }
        [HttpPost]
        public ActionResult Create(MasjidLandRequest model)
        {
            if (model != null)
            {
                _MasjidLandRequestBusiness.SaveMasjidLandRequest(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                _MasjidLandRequest.Id = Convert.ToInt32(id);
                _MasjidLandRequestBusiness.Delete(_MasjidLandRequest);
            }

            return RedirectToAction("Index");
        }
    }
}