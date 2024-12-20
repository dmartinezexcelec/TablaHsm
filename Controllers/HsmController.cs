using HSM2.Models;
using HSM2.Service;
using Microsoft.AspNetCore.Mvc;

namespace HSM2.Controllers
{
    public class HomeController : Controller
    {
        private readonly HsmService _hsmService;

        public HomeController(HsmService hsmService)
        {
            _hsmService = hsmService;
        }

        public IActionResult Index()
        {
            var hsmData = _hsmService.GetHsmData();
            return View(hsmData);
        }
    }
}