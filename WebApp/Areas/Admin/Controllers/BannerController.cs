using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApp.Areas.Admin.Service;
using WebApp.Models;

namespace WebApp.Areas.Admin.Controllers
{
    public class BannerController : Controller
    {
        private BannerService bannerService;

        public BannerController(IOptions<AppSettings> settings)
        {
            bannerService = new BannerService(settings);
        }
        // GET: BannerController
        public ActionResult Index(int pageIndex,int pageSize)
        {
            var model = bannerService.GetAllBanner(pageIndex, pageSize);
            return View(model);
        }

        // GET: BannerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BannerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BannerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BannerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BannerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BannerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BannerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
