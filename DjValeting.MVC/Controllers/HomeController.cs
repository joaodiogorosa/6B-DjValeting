using DjValeting.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DjValeting.MVC.Data;

namespace DjValeting.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _context = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {

            string name, email, number;
            DateTime date;
            int flexibility, vehicleSize;


            name = Request.Form["tbxName"].ToString();
            email = Request.Form["tbxEmail"].ToString();
            number = Request.Form["tbxNumber"].ToString();
            DateTime.TryParse(Request.Form["tbxDate"].ToString(), out date);
            int.TryParse(Request.Form["selFlexibility"].ToString(), out flexibility);
            int.TryParse(Request.Form["selVehicleSize"].ToString(), out vehicleSize);

            ClientModel cModel = new()
            {
                Name = name,
                Email = email,
                ContactNumber = number,
                BookingDate = date,
                Flexibility = flexibility,
                VehicleSize = vehicleSize
            };

            var xpto1 = _context.clientModels.Add(cModel);
            var xpto2 = _context.SaveChanges();

            return RedirectToAction(nameof(Success));
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