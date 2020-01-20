using CarparkApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarparkApi.Data
{
    public class CarparkContext:DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public CarparkContext(DbContextOptions options): base(options)
        {

        }
    }
}
