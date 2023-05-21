using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartWebApp.Model
{
    public class Product
    {
        [Key]
       public int Id { get; set; }
        [Required]
        public string ? Name { get; set; }
        [Required]
        public string Catagory { get; set; }
        [Required]
        public string ? Description { get; set; }
        [Required]

        public int Price { get; set; }
        [Required]
        public int  Quantity { get; set; }
        

    }

}
