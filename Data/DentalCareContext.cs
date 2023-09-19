using Microsoft.EntityFrameworkCore;
using DentalCare.Models;

namespace DentalCare.Data
{
    public class DentalCareContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=DentalCare;User Id=sa;Password=Password123;Encrypt=false;");
        }
    }
}

