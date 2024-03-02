using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarManagementApp.Models;

namespace CarManagementApp.Data
{
    public class CarManagementAppContext : DbContext
    {
        public CarManagementAppContext (DbContextOptions<CarManagementAppContext> options)
            : base(options)
        {
        }
        public DbSet<Car> Car { get; set; }
    }
}
