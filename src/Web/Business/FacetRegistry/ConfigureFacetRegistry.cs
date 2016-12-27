using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace EPi.Commerce.Web.Business.FacetRegistry
{
    [InitializableModule]
    public class ConfigureFacetRegistryInContainer : IConfigurableModule
    {

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(c => c.For<IFacetRegistry>().Use<FacetRegistry>());
        }

        public void Initialize(InitializationEngine context)
        {
            
        }

        public void Uninitialize(InitializationEngine context)
        {
         
        }

        public void Preload(string[] parameters)
        {
         
        }
    }
}