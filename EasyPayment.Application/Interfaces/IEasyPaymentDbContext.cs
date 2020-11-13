using EasyPayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyPayment.Application.Interfaces
{
    public interface IEasyPaymentDbContext
    {
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<AppRegistry> AppRegistries { get; set; }
        public DbSet<PaymentSetup> PaymentSetups { get; set; }
        public DbSet<PaymentLog> PaymentLogs { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();
    }
}
