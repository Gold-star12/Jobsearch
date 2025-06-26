using Microsoft.EntityFrameworkCore;
using JobSearchDataLayer.DataDTO;

namespace JobSearchDataLayer
{
    public class JSDbcontext : DbContext
    {
        DbSet<Company> Companies { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Application> Applications { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserProfile> UserProfiles { get; set; }
        DbSet<JobSkill> JobSkills { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = JobSearchDB;Integrated Security=True;Trust Server Certificate=True");
            }
        }
    }
}
