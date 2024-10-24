using Catalog.Service.Catalog;

namespace Catalog.Aplication.Catalog
{
    public class AplicCatalog : IAplicCatalog
    {
        private readonly IServCatalog _servCatalog;

        public AplicCatalog(ServCatalog servCatalog)
        {
            _servCatalog = servCatalog; 
        }
    }
}
