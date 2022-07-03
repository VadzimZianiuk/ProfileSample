using ProfileSample.DAL;
using ProfileSample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProfileSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ImageModel> model;
            using (var context = new ProfileSampleEntities())
            {
                model = context.ImgSources.Take(20).Select(x => new ImageModel()
                {
                    Name = x.Name,
                    Data = x.Data
                }).ToList();
            }

            return View(model);
        }

        public ActionResult Convert()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}