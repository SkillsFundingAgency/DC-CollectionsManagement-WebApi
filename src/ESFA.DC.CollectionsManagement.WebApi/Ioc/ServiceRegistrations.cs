using System;
using System.Collections.Generic;
using Autofac;
using ESFA.DC.CollectionsManagement.Interfaces;
using ESFA.DC.CollectionsManagement.Services;
using ESFA.DC.CollectionsManagement.WebApi.Settings;
using ESFA.DC.DateTime.Provider;
using ESFA.DC.DateTime.Provider.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ESFA.DC.CollectionsManagement.WebApi.Ioc
{
    public class ServiceRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RetrunCalendarService>().As<IRetrunCalendarService>().InstancePerLifetimeScope();
            builder.RegisterType<OrganisationService>().As<IOrganisationService>().InstancePerLifetimeScope();
            builder.RegisterType<DateTimeProvider>().As<IDateTimeProvider>().InstancePerLifetimeScope();

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