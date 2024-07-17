using Microsoft.AspNetCore.Mvc;
using TemplatingRazor.Models

namespace TemplatingRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            List<Expenditure> expenditures = new List<Expenditure>()
            {
                new Expenditure(1, "Adieu ma retraite", new DateTime(2024, 7, 17), 25000.50)
            };
            return View();
        }
    }
}
