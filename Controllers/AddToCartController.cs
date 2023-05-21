using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCartWebApp.Auth;
using ShoppingCartWebApp.Model;

namespace ShoppingCartWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles ="User")]
    public class AddToCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AddToCartController(ApplicationDbContext context)
        {
            this._context = context;

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var cart = await _context.Carts.ToListAsync();
            if (cart != null)
            {
                return Ok(cart);
            }
            return NotFound();
        }
        [HttpPost("AddCart")]
        public async Task<IActionResult> AddCart(ProductModel prod)
        {
            var product= await _context.Carts.Where(x=>x.Name==prod.Name).FirstOrDefaultAsync();
            var cart = new Cart();
            if (product != null)
            {
                cart.Id = product.Id;
                cart.Name = product.Name;
                cart.Description = product.Description;
                cart.Catagory = product.Catagory;
                cart.Price = product.Price;
                cart.Quantity = product.Quantity+1;
                 
                await _context.SaveChangesAsync();
                return Ok(cart);
            }
            else
            {
                
                cart.Name = prod.Name;
                cart.Description = prod.Description;
                cart.Catagory = prod.Catagory;
                cart.Price = prod.Price;
                cart.Quantity = prod.Quantity;
                _context.Carts.Add(cart);

                await _context.SaveChangesAsync();
                return Ok(cart);
            }
            
             
                
        }
        [HttpGet("Checkout")]
        public async Task<IActionResult> Checkout()
        {
            var cart = await _context.Carts.ToListAsync();
            foreach (var item in cart)
            {
                _context.Checkouts.Add(new Checkout { Name = item.Name, Catagory = item.Catagory, Description = item.Description, Price = item.Price, Quantity = item.Quantity });
            }
            foreach (var item in cart)
            {
                if (item != null)
                {
                    _context.Carts.Remove(item);
                }
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
