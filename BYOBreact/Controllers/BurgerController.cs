using BYOBreact.Model;
using BYOBreact.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web;

namespace BYOBreact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class BurgerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BurgerController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet("MakeBurger")]
        public BurgerViewModel MakeBurger()
        {
            //Guid guid = Guid.NewGuid();
            ////var a = 10;
            ////var buns = _context.Bun.ToList();
            //return _context.Bun;
            var burgerMuffins = _context.BurgerMuffins.ToList();
            var sauces = _context.Sauces.ToList();
            var vegetables = _context.Vegetables.ToList();
            var meat = _context.Meat.ToList();
            var viewModel = new BurgerViewModel
            {
                Burger = new Burger(),
                Vegetables = vegetables,
                Meats = meat,
                Sauces = sauces,
                BurgerMuffins= burgerMuffins
            };
            return viewModel;
        }

        [HttpGet("GetBurgerItems")]
        public BurgerViewModel GetBurgerItems()
        {
            var burgerMuffins = _context.BurgerMuffins.ToList();
            var sauces = _context.Sauces.ToList();
            var vegetables = _context.Vegetables.ToList();
            var meat = _context.Meat.ToList();
            var viewModel = new BurgerViewModel
            {
                Burger = new Burger(),
                Vegetables = vegetables,
                Meats = meat,
                Sauces = sauces,
                BurgerMuffins = burgerMuffins
            };
            return viewModel;
        }
        [HttpPost("CustomerBurger")]
        public void CustomerBurger(Burger burger)
        {
            Console.WriteLine("burger", burger);
            _context.Burger.Add(burger);
            _context.SaveChanges();
        }
    }
}
