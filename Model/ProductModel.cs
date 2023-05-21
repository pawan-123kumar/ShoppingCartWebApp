using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCartWebApp.Model
{
    public class ProductModel
    {
        public string? Name { get; set; }
        [Required]

        public string? Description { get; set; }
        [Required]
        public string Catagory { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
       public int Quantity { get; set; }        
    }
}
