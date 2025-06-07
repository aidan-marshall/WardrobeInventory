using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WardrobeInventory.Models;

namespace WardrobeInventory.Data
{
    public class WardrobeInventoryContext(DbContextOptions<WardrobeInventoryContext> options) : DbContext(options)
    {
        public DbSet<WardrobeItem> WardrobeItems { get; set; }
    }
}
