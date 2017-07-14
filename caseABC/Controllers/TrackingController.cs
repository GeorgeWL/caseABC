using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using caseABC.Data.DAO;
using caseABC.Data.IDAO;
using caseABC.Services.Service;
using caseABC.Services.IService;

namespace caseABC.Controllers
{
    public class TrackingController : Controller
    {
        private IabcService _abcService;
        public TrackingController()
        {
            _abcService = new abcService();
        }
        // GET: Tracking
        public ActionResult Index()
        {
            return View();
        }
    }
}
