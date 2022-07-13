using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace MailContainerTest
{
    public static class DependencyInjection
    {
        //public static IServiceCollection AddMailContainerTest(this IServiceCollection services, IConfiguration configuration)
        //{
            //var section = configuration.GetSection(DataStoreTypeOptions.DataStoreTypeConfig);
            //var section = configuration.GetSection("Backup");
           // services.Configure<DataStoreTypeOptions>(options => section.Bind(options));
            //services.AddScoped<IMailContainerDataStoreFactory, MailContainterDataStoreFactory>();
            //services.AddScoped<IMailTransferService, MailTransferService>();
           // return services;
        //}
    }
}
