using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static
{
    public class PizzeriaController : Controller
    {
        public readonly IWebHostEnvironment _webHostEnvironment;

        public PizzeriaController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var pizze = new List<Pizza>
            {
                new Pizza
                {
                    Image =  "margherita.jpg",
                    Name = "Margherita",
                    Ingredients = "pomodoro, mozzarella, basilico fresco, sale, olio.",
                    Price = 5.00m
                },
                new Pizza
                {
                    Image = "prosciutto-e-funghi.jpg",
                    Name = "Prosciutto e funghi",
                    Ingredients = "pomodoro, mozzarella, prosciutto cotto, funghi champignon, sale, olio.",
                    Price = 6.50m
                },
                new Pizza
                {
                    Image = "viennese.jpg",
                    Name = "Viennese",
                    Ingredients = "pomodoro, mozzarella, wurstel, sale, olio.",
                    Price = 6.00m
                },
                new Pizza
                {
                    Image = "diavola.jpg",
                    Name = "Salamino piccante",
                    Ingredients = "pomodoro, mozzarella, salamino piccante, sale, olio.",
                    Price = 6.50m
                },
            };

            return View(pizze);
        }
    }
}
