using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using KV_API.Models;

namespace KV_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // --------------------------------- Get  ---------------------------//
        public DbSet<partier> KommunalValg2021 { get; set; }
    
    }
}
