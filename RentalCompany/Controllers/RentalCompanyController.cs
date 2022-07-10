using Microsoft.AspNetCore.Mvc;
using RentalCompany.Models;

namespace RentalCompany.Controllers
{
    public class RentalCompanyController : Controller
    {
        private RentalCompanyContext db { get; set; }
        public RentalCompanyController(RentalCompanyContext context)
        {
            db = context;
        }
        public IActionResult Customers()
        {
            return View(db.Customers.ToList());
        }

        public IActionResult Customer(int? customerId)
        {
            if(customerId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                foreach(Customer customer in db.Customers)
                {
                    if(customer.Id == customerId)
                    {
                        return View(customer);
                    }
                }
            }
            return View();
        }

        public IActionResult Equipments()
        {
            return View(db.Equipment.ToList());
        }
        public IActionResult AllRentals()
        {
            List<Rental> allRentals = db.Rentals.ToList();
            return View(allRentals);
        }

        public IActionResult Rent(string? equipment, int? customerId)
        {
            if (equipment == null && customerId == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Rental rental = new Rental();
                rental.IsCurrent = true;
            }
            return View();
        }

    }
}
