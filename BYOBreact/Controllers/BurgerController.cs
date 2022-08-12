using BYOBreact.Model;
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
        private ApplicationDbContext _context;
        public BurgerController()
        {
            _context = new ApplicationDbContext();
        }
        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}

        [HttpGet("MakeBurger")]
        public string MakeBurger()
        {
            Guid guid = Guid.NewGuid();

            return guid.ToString();
        }
    }
}
