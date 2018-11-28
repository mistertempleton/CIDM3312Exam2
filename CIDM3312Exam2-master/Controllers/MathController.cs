using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using CIDM3312Exam2.Models;

namespace CIDM3312Exam2.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult DoCalculation ()

        {
            MathOperation model = new MathOperation();
            return View(model);
        }

        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation model)
        {
            
            return View(model);
        }
    }
}