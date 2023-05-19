﻿using InquiryPolicyDetailByInsuredDataAPI.DataAccess.Entities;
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

        public DbSet<PolicyDetailByInsuredData> PolicyDetailByInsuredData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PolicyDetailByInsuredData>(entity => entity.HasNoKey());
        }
    }
}
