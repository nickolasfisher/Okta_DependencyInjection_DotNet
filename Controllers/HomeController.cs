using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OktaDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using OktaDependencyInjection.Services.Interfaces;

namespace OktaDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INumberOfHitsService _numberOfHitsService;
        private readonly IOktaService _oktaService;
        private readonly IRandomUpperAndLowerService _randomUpperAndLowerService;

        public HomeController(
            ILogger<HomeController> logger,
            INumberOfHitsService numberOfHitsService,
            IOktaService oktaService,
            IRandomUpperAndLowerService randomUpperAndLowerService)
        {
            _logger = logger;
            _numberOfHitsService = numberOfHitsService;
            _oktaService = oktaService;
            _randomUpperAndLowerService = randomUpperAndLowerService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var users = await _oktaService.GetUsersAsync();
            var hits = _numberOfHitsService.NumberOfHits;

            var appName = _randomUpperAndLowerService.RandomizeString("dependency injection with okta");

            HomeModel model = new HomeModel(appName, users, hits);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
