using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace la_mia_pizzeria_static
{
    public class PizzeriaController : Controller
    {
        public IActionResult Index()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> pizze = db.Pizze.ToList();

                return View(pizze);
            }
           
        }

        //public IActionResult Details(int id)
        //{
        //    using (PizzeriaContext context = new PizzeriaContext())
        //    {
        //        var pizzaId = context.Pizze.FirstOrDefault(p => p.Id == id);
                
        //        return View("Details", pizzaId);
        //    }
        //}

    }
}
