using Microsoft.EntityFrameworkCore;
using ModelShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSide.DataAccess
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<WeatherForecast> Weathers { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}
