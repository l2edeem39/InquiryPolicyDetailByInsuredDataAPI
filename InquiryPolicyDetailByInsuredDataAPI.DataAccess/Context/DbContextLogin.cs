using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Context
{
    public class DbContextLogin : DbContext
    {
        //public DbContextClass(DbContextOptions<DbContextClass> options)
        //    : base(options)
        //{
        //}

        protected readonly IConfiguration Configuration;

        public DbContextLogin(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("HQCDBAPIDEV"));
        }

        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<LogDetail> LogDetail { get; set; }
        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogin>().HasKey(o => o.Id);
            modelBuilder.Entity<LogDetail>().HasKey(o => o.Id);
            modelBuilder.Entity<Log>().HasKey(o => o.Id);
        }
    }
}
