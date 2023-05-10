using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InquiryPolicyDetailByInsuredDataAPI.DataAccess.Context
{
    public class DbContextClass : DbContext
    {
        //public DbContextClass(DbContextOptions<DbContextClass> options)
        //    : base(options)
        //{
        //}

        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("VmiDB1"));
        }

        public DbSet<InsuredData> InsuredData { get; set; }
        public DbSet<CarcolorCode> CarcolorCode { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsuredData>(entity => entity.HasNoKey());
            modelBuilder.Entity<CarcolorCode>(entity => entity.HasNoKey());
        }
    }
}
