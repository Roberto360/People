using ApiPeople.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPeople.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }  //creando una prob DbSet<modelo>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
