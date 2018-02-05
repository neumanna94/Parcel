using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
    public class HomeController : Controller
    {
        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }
        [Route("/result")]
        public ActionResult Result()
        {
            MyParcel userParcel = new MyParcel();
            userParcel.SetLength(Request.Query["length"]);
            userParcel.SetWidth(Request.Query["width"]);
            userParcel.SetHeight(Request.Query["height"]);
            return View("Result", userParcel);
        }
      }
}
