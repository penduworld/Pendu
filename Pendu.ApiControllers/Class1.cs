using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu.ApiControllers
{
    public class ApiController : ApiControllers
    {
        public ActionResult Call()
        {
            ViewBag.Title = "Inside MyFirst Controller.";
            return View();
        }
    }
}
