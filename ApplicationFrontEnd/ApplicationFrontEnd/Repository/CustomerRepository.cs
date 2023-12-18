using ApplicationFrontEnd.Models.DTO;
using ApplicationFrontEnd.Repository.Interfaces;

namespace ApplicationFrontEnd.Repository
{
    public class CustomerRepository : Repository<CustomerDTO>, ICustomerRepository
    {
        public CustomerRepository(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory)
        {

        }
    }
}
