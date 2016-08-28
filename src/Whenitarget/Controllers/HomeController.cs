using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Moniker.Model;

namespace Moniker.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet("~/")]
        public IActionResult Index(string keys)
        {
            var network = NetworkBuilder.Build();

            var model = new MonikersVm();
            model.Network = network;
            model.ProjectType = "app";
            model.Selected = Keys.ParseKeys(keys).ToList();
            model.SelectCount = model.Selected.Count;
            Algorithm.Project(model.Network, model.Selected);
            model.Downstream = network.Items.Where(i => i.Runs == model.SelectCount).Select(i => i.Key).ToList();
            model.Upstream = network.Items.Where(i => i.RunsOn > 0).Select(i => i.Key).ToList();

            return View(model);
        }

        

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
