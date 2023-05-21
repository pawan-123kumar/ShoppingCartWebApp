using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ShoppingCartWebApp.Auth;
using ShoppingCartWebApp.Model;
using ShoppingCartWebApp.Repository;
using System.IO.Compression;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ShoppingCartWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
      
        public ProductController(ApplicationDbContext context)
        {
            this._context = context;
         
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var product = await _context.Products.ToListAsync();
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _context.Products.FindAsync(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task <IActionResult> AddProduct(ProductModel  product1)
        {
            if (ModelState.IsValid)
            {
                Product p = new Product();
                p.Name = product1.Name;
                p.Description = product1.Description;
                p.Catagory = product1.Catagory; 
                p.Price = product1.Price;
                p.Quantity = product1.Quantity;
                _context.Products.Add(p);
                await _context.SaveChangesAsync();
                return Ok(p);
            }
            return BadRequest(product1);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Product product1)
        {
            var product = await _context.Products.FindAsync(product1.Id);
            if (product != null)
            {

                
                product.Name = product1.Name;
                product.Description = product1.Description;
                product.Catagory = product1.Catagory;
                product.Price = product1.Price;
                product.Quantity = product1.Quantity;

                
                await _context.SaveChangesAsync();
                return Ok(new Responce { Status = "Success", Message = "Product has been Updated Successfully" });

            }
            return NotFound();

        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var p1 = await _context.Products.FindAsync(id);
            if (p1 != null)
            {

                _context.Remove(p1);
                await _context.SaveChangesAsync();
                return Ok(p1);
            }
            return NotFound();
        }
    }
}
