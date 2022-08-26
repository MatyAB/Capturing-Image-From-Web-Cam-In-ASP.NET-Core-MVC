using DemoWebCam.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace DemoWebCam.Controllers
{
    public class ApiContoller : Controller
    {
        Uri baseAddress = new Uri("http://localhost:83748/api");
        HttpClient client;
        
        public ApiContoller()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public ActionResult Index()
        {
            List<ApiViewModel> modelList = new List<ApiViewModel>();
            HttpResponseMessage response=client.GetAsync(client.BaseAddress+"/apiname").Result;
            if(response.IsSuccessStatusCode)
            {
               // return View(response.Content);
                string data =response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<ApiViewModel>>(data);

            }
            return View();
        }
    }
}
