using Catalog.Repository.Catalog;

namespace Catalog.Service.Catalog
{
    public class ServCatalog : IServCatalog
    {
        private readonly IRepCatalog _repCatalog;

        public ServCatalog(IRepCatalog repCatalog)
        {
            _repCatalog = repCatalog; 
        }
    }
}
