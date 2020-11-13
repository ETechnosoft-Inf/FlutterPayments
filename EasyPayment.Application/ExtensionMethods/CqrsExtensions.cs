using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace EasyPayment.Application.ExtensionMethods
{
    public static class CQRSExtensions
    {
        public static IServiceCollection AddCqrs(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }

    }
}
