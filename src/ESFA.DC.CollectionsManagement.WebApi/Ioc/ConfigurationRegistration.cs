using Autofac;
using ESFA.DC.CollectionsManagement.WebApi.Extensions;
using ESFA.DC.CollectionsManagement.WebApi.Settings;
using Microsoft.Extensions.Configuration;

namespace ESFA.DC.Job.WebApi.Ioc
{
    public static class ConfigurationRegistration
    {
        public static void SetupConfigurations(this ContainerBuilder builder, IConfiguration configuration)
        {
            builder.Register(c => configuration.GetConfigSection<ConnectionStrings>())
                .As<ConnectionStrings>().SingleInstance();
        }
    }
}