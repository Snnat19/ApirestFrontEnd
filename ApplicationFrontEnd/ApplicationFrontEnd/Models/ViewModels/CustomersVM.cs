using ApplicationFrontEnd.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ApplicationFrontEnd.Models.ViewModels
{
    public class CustomersVM
    {
        public IEnumerable<SelectListItem> ListCustomers { get; set; }
        public CustomerDTO Customer { get; set; }

    }
}
