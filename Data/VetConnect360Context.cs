using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetConnect360.Models;

namespace VetConnect360.Data
{
    public class VetConnect360Context : DbContext
    {
        public VetConnect360Context (DbContextOptions<VetConnect360Context> options)
            : base(options)
        {
        }

        public DbSet<VetConnect360.Models.Pet> Pet { get; set; } = default!;

        public DbSet<VetConnect360.Models.Owner>? Owner { get; set; }

        public DbSet<VetConnect360.Models.Service>? Service { get; set; }

        public DbSet<VetConnect360.Models.Doctor>? Doctor { get; set; }

        public DbSet<VetConnect360.Models.Appointment>? Appointment { get; set; }
    }
}
