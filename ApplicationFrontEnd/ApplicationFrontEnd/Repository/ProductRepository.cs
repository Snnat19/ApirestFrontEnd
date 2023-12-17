using ApplicationFrontEnd.Models.DTO;
using ApplicationFrontEnd.Repository.Interfaces;

namespace ApplicationFrontEnd.Repository
{
    public class ProductRepository : Repository<ProductDTO>, IProductRepository
    {
        public ProductRepository(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory)
        {

        }
    }
}
