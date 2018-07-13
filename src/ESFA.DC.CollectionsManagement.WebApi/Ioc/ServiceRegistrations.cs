using Autofac;
using ESFA.DC.CollectionsManagement.Service;

namespace ESFA.DC.CollectionsManagement.WebApi.Ioc
{
    public class ServiceRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RetrunCalendarService>().As<IRetrunCalendarService>().InstancePerLifetimeScope();
            builder.RegisterType<OrganisationService>().As<OrganisationService>().InstancePerLifetimeScope();
        }
    }
}