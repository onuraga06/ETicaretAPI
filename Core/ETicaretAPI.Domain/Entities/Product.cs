using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretAPI.Domain.Entities
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public DateTime CreatedData { get; set; }
      
       
    }
}
