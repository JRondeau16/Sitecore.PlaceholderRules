using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.PlaceholderRules.Rules;

namespace Sitecore.PlaceholderRules
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IRulesRunner, RulesRunner>();
        }
    }
}