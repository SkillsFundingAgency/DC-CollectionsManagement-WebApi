using System;
using System.Collections.Generic;
using Autofac;
using ESFA.DC.CollectionsManagement.Services;
using ESFA.DC.CollectionsManagement.Services.Interface;
using ESFA.DC.CollectionsManagement.WebApi.Settings;
using ESFA.DC.DateTimeProvider.Interface;
using Microsoft.EntityFrameworkCore;

namespace ESFA.DC.CollectionsManagement.WebApi.Ioc
{
    public class ServiceRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReturnCalendarService>().As<IReturnCalendarService>().InstancePerLifetimeScope();
            builder.RegisterType<OrganisationService>().As<IOrganisationService>().InstancePerLifetimeScope();
            builder.RegisterType<DateTimeProvider.DateTimeProvider>().As<IDateTimeProvider>().InstancePerLifetimeScope();

            builder.Register(context =>
                {
                    var settings = context.Resolve<ConnectionStrings>();
                    var optionsBuilder = new DbContextOptionsBuilder();
                    optionsBuilder.UseSqlServer(
                        settings.CollectionsManagement,
                        options => options.EnableRetryOnFailure(3, TimeSpan.FromSeconds(3), new List<int>()));

                    return optionsBuilder.Options;
                })
                .As<DbContextOptions>()
                .InstancePerLifetimeScope();
        }
    }
}