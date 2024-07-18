using Microsoft.AspNetCore.Mvc;
using TemplatingRazor.Models;

namespace TemplatingRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult List()
        {
            List<Expenditure> expenditures = new List<Expenditure>()
            {
                new Expenditure(1, "Adieu ma retraite", new DateTime(2024, 7, 17), 25000.50),
                new Expenditure(1, "Je suis à la rue", new DateTime(2021, 4, 3), 12555.00),
                new Expenditure(1, "Merci les allocs", new DateTime(2020, 3, 24), 3)
            };
            return View("List", expenditures);
        }
    }
}
