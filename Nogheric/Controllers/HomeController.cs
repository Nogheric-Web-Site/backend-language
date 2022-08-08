//using Microsoft.AspNetCore.Mvc;
//using Nogheric.Models;
using System;
using System.Collections.Generic;
//using System.Globalization;
using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
//using System.Web.UI;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Authorization;

////using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Security.Claims;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
//using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Nogheric.Controllers
{
    //[Authorize]
    ////[Authorize(Policy = "SecurityAlmacenes")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _context;
        ////private readonly SqlConnection _conexion;
        //private GlobalService globalS;

        //public AlmacenesController(ApplicationDbContext context)
        //{
        //    _context = context;
        //    //  _conexion = Connection.GetConexion();
        //    globalS = new GlobalService(_context);
        //}
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> GetLanguage(PageIndex pageIndex)
        //{
        //    try
        //    {
        //        switch (pageIndex.Language)
        //        {
        //            case 1:
        //                //english
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        //                Console.WriteLine("Ahora en Inglés (USA)");
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                break;
        //            case 2:
        //                //english
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        //                Console.WriteLine("Ahora en Inglés (USA)");
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                break;
        //            case 3:
        //                //english
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        //                Console.WriteLine("Ahora en Inglés (USA)");
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                break;
        //            case 4:
        //                //english
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        //                Console.WriteLine("Ahora en Inglés (USA)");
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                break;
        //            case 5:
        //                //english
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        //                Console.WriteLine("Ahora en Inglés (USA)");
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                break;
        //            default:
        //                //english
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        //                Console.WriteLine("Ahora en Inglés (USA)");
        //                Console.WriteLine(pageIndex.Head);
        //                Console.WriteLine(pageIndex.Body);
        //                Console.WriteLine(pageIndex.Foot);
        //                break;
        //        }

        //        return Ok(new { status = 200, message = "Datos importados correctamente.", response = pageIndex });
        //    }
        //    catch (Exception e)
        //    {
        //        return Ok(new { status = 400, message = "Datos importados correctamente." });
        //    }
        //}

        //private IActionResult Ok(object p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
