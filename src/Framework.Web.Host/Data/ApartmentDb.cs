using Framework.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Framework.Web.Data
{
    public class ApartmentDb : DbContext
    {
        public ApartmentDb(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Apartment> AbpApartments { get; set; }
    }
}
