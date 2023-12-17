using ApplicationFrontEnd.Models.DTO;
using ApplicationFrontEnd.Repository.Interfaces;

namespace ApplicationFrontEnd.Repository
{
    public class OrderRepository : Repository<OrderDTO>, IOrderRepository
    {
        public OrderRepository(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory)
        {

        }
    }
}
