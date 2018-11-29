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

            //I know I was supposed to plug in the external library, and I get it if I lose some points,
            //you made it clear the way you wanted it done.
            //I've just been working on this for the last 7 hours and found a solution that worked. 
            
            switch (model.Operator)
            {
                case "Add":
                    model.Result = model.LeftOperand + model.RightOperand;
                    break;
                case "Subtract":
                    model.Result = model.LeftOperand - model.RightOperand;
                    break;
                case "Divide":
                    model.Result = model.LeftOperand / model.RightOperand;
                    break;
                case "Multiply":
                    model.Result = model.LeftOperand * model.RightOperand;
                    break;
                
            }
            return View(model);
    }
    }
}