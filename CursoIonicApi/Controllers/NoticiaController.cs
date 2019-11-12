using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CursoIonicApi.Controllers
{
    public class NoticiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}