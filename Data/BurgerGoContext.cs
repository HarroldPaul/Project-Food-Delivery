using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BurgerGo.Domain;

namespace BurgerGo.Data
{
    public class BurgerGoContext : DbContext
    {
        public BurgerGoContext (DbContextOptions<BurgerGoContext> options)
            : base(options)
        {
        }

        public DbSet<BurgerGo.Domain.MenuItem> MenuItem { get; set; } = default!;
        public DbSet<BurgerGo.Domain.Order> Order { get; set; } = default!;
        public DbSet<BurgerGo.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<BurgerGo.Domain.Promotion> Promotion { get; set; } = default!;
    }
}
