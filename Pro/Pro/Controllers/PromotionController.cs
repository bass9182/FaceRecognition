using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Promotion.Models;


namespace Promotion.Webapp.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }
        
        
    }
}