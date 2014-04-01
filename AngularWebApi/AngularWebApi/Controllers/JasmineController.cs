using System;
using System.Web.Mvc;

namespace AngularWebApi.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
