using Catalog.Aplication.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers.Catalog
{
    [ApiController]
    [Route("api/v1/catalog")]
    public class CatalogController : ControllerBase
    {
        private readonly IAplicCatalog _aplicCatalog;

        public CatalogController(IAplicCatalog aplicCatalog)
        {
            _aplicCatalog = aplicCatalog;
        }
    }
}
