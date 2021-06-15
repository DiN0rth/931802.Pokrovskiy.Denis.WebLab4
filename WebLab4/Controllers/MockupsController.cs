using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebLab4.Models;

namespace WebLab4.Controllers
{
    public class MockupsController : Controller
    {
        SignUp signup;
        private readonly ILogger<MockupsController> _logger;

        public MockupsController(ILogger<MockupsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Confirm(string value)
        {
            SignUp signup = new SignUp();
            if (Request.Method == "POST")
            {
                if (signup.ResetCode == value)
                    return View("Result2");
                else ViewBag.Check = "Wrong code!";
                return View();
            }
            else return View();
        }

        [HttpGet]
        public IActionResult PassReset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PassReset(SignUp signup, string action)
        {
            if (ModelState["Email"].ValidationState == ModelValidationState.Valid)
            {
                if (action == "Send me a code")
                {
                    ViewBag.ResetCode = "Code: " + signup.ResetCode;
                    return View();
                }
                return Redirect("Confirm");
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignUp(SignUp user)
        {
            if (ModelState["FirstName"].ValidationState == ModelValidationState.Valid &
                ModelState["LastName"].ValidationState == ModelValidationState.Valid &
                ModelState["Gender"].ValidationState == ModelValidationState.Valid)
                return RedirectToAction("SignUp2", user);
            return View();
        }

        [HttpGet]
        public IActionResult SignUp2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp2(SignUp user)
        {
            if (ModelState["Email"].ValidationState == ModelValidationState.Valid &
                ModelState["Password"].ValidationState == ModelValidationState.Valid &
                ModelState["ComparePassword"].ValidationState == ModelValidationState.Valid)
                return View("Result", user);

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
