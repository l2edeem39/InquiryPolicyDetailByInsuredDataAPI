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
            options.UseSqlServer(Configuration.GetConnectionString("r4ad01"));
        }

        public DbSet<InsuredData> InsuredData { get; set; }
        public DbSet<ProductFch> ProductFch { get; set; }
        public DbSet<PolicyDetailByInsuredData> PolicyDetailByInsuredData { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsuredData>(entity => entity.HasNoKey());
            modelBuilder.Entity<ProductFch>(entity => entity.HasNoKey());
            modelBuilder.Entity<PolicyDetailByInsuredData>(entity => entity.HasNoKey());
            modelBuilder.Entity<User>(entity => entity.HasNoKey());
        }
    }
}
