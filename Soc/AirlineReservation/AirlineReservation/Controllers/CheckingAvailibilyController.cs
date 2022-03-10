using Microsoft.AspNetCore.Mvc;

namespace AirlineReservation.Controllers
{
    public class CheckingAvailibilyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
