using Microsoft.AspNetCore.Mvc;
using ProyHotel.Web.Models;
using System.Diagnostics;

namespace ProyHotel.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContextLPL _dbContext;
        private readonly IEmailSender _emailSender;
        public HomeController(ILogger<HomeController> logger, DataContextLPL dbContext, IEmailSender emailSender)
        {
            _logger = logger;
            _dbContext = dbContext;
            _emailSender = emailSender;

        }

        public IActionResult Index()
        {
            var hotel = _dbContext.Hotel.Where(c => c.Estatus == true);
            //_emailSender.SendEmailAsnyc("cpintoc@fcpn.edu.bo","Este es un correo", "Bienvenido al Hotel")
            return View();
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