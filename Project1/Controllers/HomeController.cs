using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missions()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ldsorg()
        {
            return Redirect("http://www.lds.org");
        }

        public ActionResult Inspiring()
        {
            return View();
        }

        public ActionResult MissionFAQs(string Mission)
        {
            if (Mission == "London")
            {
                ViewBag.Mission = "England London Mission";
                ViewBag.PresidentName = "President and Sister Stevens";
                ViewBag.Address = "64-68 Princes Gate,     Exhibition Road, South Kensington,     London, England SW7 2PA";
                ViewBag.Language = "English";
                ViewBag.Climate = "Temperate Oceanic";
                ViewBag.DominateReligion = "Anglican (Church of England - Christian)";
                ViewBag.CountryImage = "../../Content/" + Mission + ".jpg";
                ViewBag.MissionFlag ="../../Content/EnglishFlag.png";

            }
            else if (Mission == "Milan")
            {
                ViewBag.Mission = "Italy Milan Mission";
                ViewBag.PresidentName = "President and Sister Allen";
                ViewBag.Address = "Via A. Gramsci, 13/2,     20090 Opera (MI),   ITALY";
                ViewBag.Language = "Italian";
                ViewBag.Climate = "Humid Subtropical";
                ViewBag.DominateReligion = "Roman Catholic";
                ViewBag.CountryImage = "../../Content/" + Mission + ".jpg";
                ViewBag.MissionFlag = "../../Content/ItalyFlag.jpg.svg";

            }
            else if (Mission == "Boston")
            {
                ViewBag.Mission = "Massachusetts Boston Mission";
                ViewBag.PresidentName = "President and Sister MIller";
                ViewBag.Address = "Via A. Gramsci, 13/2, 20090 Opera (MI), ITALY";
                ViewBag.Language = "English";
                ViewBag.Climate = "Humid Subtropical";
                ViewBag.DominateReligion = "Roman Catholic";
                ViewBag.CountryImage = "../../Content/" + Mission + ".jpg";
                ViewBag.MissionFlag = "../../Content/MassFlag.png";
            }
            

            return View();
        }
    }
}