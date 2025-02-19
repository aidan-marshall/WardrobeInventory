using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WardrobeInventory.Models;

namespace WardrobeInventory.Data
{
    public class WardrobeInventoryContext : DbContext
    {
        public WardrobeInventoryContext (DbContextOptions<WardrobeInventoryContext> options)
            : base(options)
        {
        }

        public DbSet<WardrobeInventory.Models.WardrobeItem> WardrobeItem { get; set; } = default!;
    }
}
