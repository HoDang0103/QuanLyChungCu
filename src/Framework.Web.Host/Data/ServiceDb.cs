using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Framework.Web.Data
{
    public class ServiceDb : DbContext
    {
        public ServiceDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Service> AbpServices { get; set; }
    }
}
