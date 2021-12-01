using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCountry.Models;

namespace MvcCountry.Data
{
    public class MvcCountryContext : DbContext
    {
        public MvcCountryContext (DbContextOptions<MvcCountryContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCountry.Models.Country> Country { get; set; }
    }
}
