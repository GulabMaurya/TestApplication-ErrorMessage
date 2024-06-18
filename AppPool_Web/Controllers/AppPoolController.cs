using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppPool_Web.Services;
using System.Web.Mvc;
using System.Threading.Tasks;


namespace AppPool_Web.Controllers
{


    public class AppPoolController : Controller
    {
        private readonly RemoteAppPoolService _appPoolService;

        public AppPoolController()
        {
            // Initialize with the base URL of your remote server API
            _appPoolService = new RemoteAppPoolService("https://localhost:7198/");
        }

        public async Task<ActionResult> Index()
        {
            var appPools = await _appPoolService.GetAppPoolsAsync();
            return View(appPools);
        }

        [HttpPost]
        public async Task<ActionResult> Recycle(string name)
        {
            await _appPoolService.RecycleAppPoolAsync(name);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Start(string name)
        {
            await _appPoolService.StartAppPoolAsync(name);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Stop(string name)
        {
            await _appPoolService.StopAppPoolAsync(name);
            return RedirectToAction("Index");
        }
    }

}