using Microsoft.AspNetCore.Mvc;
using DemoWebCam.Models;
using System.IO;

namespace DemoWebCam.Controllers
{
    public class ResultController : Controller
    {

        bool facematch = true;
        public IActionResult Success()
        {
            facematch = true;
            return View();
        }
        
    }
}
