using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Middleware.ErrorHandling.Controllers
{
   [Route("Error")]
   public class ErrorController : Controller
   {
      public IActionResult Error404()
      {
         return View();
      }

      [Route("404")]
      public IActionResult Error(string statusCode)
      {
         return Content($"Error Code is: {statusCode}");
      }
   }
}
