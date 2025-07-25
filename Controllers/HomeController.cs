using Microsoft.AspNetCore.Mvc;
using SentimentWebApp.Models;

namespace SentimentWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userComment)
        {
            if (string.IsNullOrWhiteSpace(userComment))
            {
                ViewBag.SentimentResult = "Yorum boş olamaz.";
                return View();
            }

            // Basit bir örnek analiz (gerçek model entegresi için burası değişecek)
            string result;
            if (userComment.ToLower().Contains("iyi") || userComment.ToLower().Contains("güzel"))
            {
                result = "Positive";
            }
            else if (userComment.ToLower().Contains("kötü") || userComment.ToLower().Contains("berbat"))
            {
                result = "Negative";
            }
            else
            {
                result = "Neutral";
            }

            ViewBag.SentimentResult = result;
            return View();
        }
    }
}
