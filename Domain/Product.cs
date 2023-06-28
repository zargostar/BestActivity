using Domain.Commen;

namespace Domain
{
    public class Product:EntityBase
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; } 
    }
}
