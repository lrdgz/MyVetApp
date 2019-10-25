using Microsoft.EntityFrameworkCore;
using MyVetApp.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVetApp.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}


        public DbSet<Owner> Owners { get; set; }
    }
}
