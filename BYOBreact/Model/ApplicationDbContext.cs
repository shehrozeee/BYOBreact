using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = System.Data.Entity.DbContext;

namespace BYOBreact.Model
{
    public class ApplicationDbContext:DbContext
    {
        public System.Data.Entity.DbSet<Burger> Burger { get; set; }
        public System.Data.Entity.DbSet<BurgerBun> BurgerBun { get; set; }

    }
}
