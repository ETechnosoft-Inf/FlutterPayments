using EasyPayment.Application.Interfaces;
using EasyPayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EasyPayment.Persistence
{
    public class AppDbContext: DbContext, IEasyPaymentDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<AppRegistry> AppRegistries { get; set; }
        public DbSet<PaymentSetup> PaymentSetups { get; set; }
        public DbSet<PaymentLog> PaymentLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    
    }
}
