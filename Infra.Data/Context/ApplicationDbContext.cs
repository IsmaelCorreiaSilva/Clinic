
using Domain.Entities;
using Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{

    public class ApplicationDbContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DoctorMap());
        }
    }
}
