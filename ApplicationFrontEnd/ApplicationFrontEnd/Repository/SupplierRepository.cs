using ApplicationFrontEnd.Models.DTO;
using ApplicationFrontEnd.Repository.Interfaces;

namespace ApplicationFrontEnd.Repository
{
    public class SupplierRepository : Repository<SupplierDTO>, ISupplierRepository
    {
        public SupplierRepository(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory)
        {

        }
    }
}
