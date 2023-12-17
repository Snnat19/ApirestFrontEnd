namespace ApplicationFrontEnd.Models.DTO
{
    public class OrderDTO
    {

        public int Id { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public Guid OrderNumber { get; set; } = Guid.NewGuid(); // Establece un nuevo GUID por defecto


        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; } = 0;


        //public virtual ICollection<OrderItemDTO> OrderItemsDTO { get; set; }


    }
}
