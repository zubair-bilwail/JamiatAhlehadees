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
    public class MasjidExtensionController : Controller
    {
        private MasjidExtension _MasjidExtension;
        private readonly IMasjidExtension _MasjidExtensionBs;

        public MasjidExtensionController()
        {
            _MasjidExtension = new MasjidExtension();
            _MasjidExtensionBs = new MasjidExtensionBs();
        }
        // GET: Admin/MasjidExtension
        public ActionResult Index()
        {
            var masjidextension = _MasjidExtensionBs.MasjidExtensionListf();
            return View(masjidextension);
        }

        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                var _MasjidExtension = _MasjidExtensionBs.GetById(Convert.ToInt32(id));
                return View(_MasjidExtension);

            }
            else
            {
                _MasjidExtension.MasjidExtensionList = _MasjidExtensionBs.MasjidExtensionListf().ToList();
                return View(_MasjidExtension);

            }

        }
        [HttpPost]
        public ActionResult Create(MasjidExtension model)
        {
            if (model != null)
            {
                _MasjidExtensionBs.SaveMasjidExtension(model);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null && id != 0)
            {
                _MasjidExtension.Id = Convert.ToInt32(id);
                _MasjidExtensionBs.Delete(_MasjidExtension);
            }

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (id != null && id != 0)
            {
                _MasjidExtension = _MasjidExtensionBs.GetById(id);
            }
            return View(_MasjidExtension);
        }
    }
}