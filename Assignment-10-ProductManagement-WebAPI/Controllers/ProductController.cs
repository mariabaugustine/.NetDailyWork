using Assignment_10_ProductManagement_WebAPI.Models;
using Assignment_10_ProductManagement_WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_10_ProductManagement_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       ProductService productService=new ProductService();
       private  IProductService _productService;
       public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
     public IActionResult Post([FromBody]Product product)
        {
            _productService.AddProduct(product);
            return Ok("Product Added Successfully");
        }
        [HttpGet]
        public IActionResult Get() 
        {
            var allList=_productService.GetAllProducts();
            if (allList.Count() == 0)
            {
                return NotFound("No Record Found");
            }
            return Ok(allList); 
        }
        [HttpPut("{id}")]
        public IActionResult Post (int id,[FromBody]Product product)
        {
            _productService.UpdateProduct(id,product);
            return Ok("Product updated successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            _productService.DeleteProduct(id);
            return Ok("Product Deleted Successfully");
        }
        [HttpGet("{amount}")]
        public IActionResult Get(double amount)
        {
            var list=_productService.GetProductByAmount(amount);
            if(list.Count() == 0)
            {
                return NotFound("No Record Found");
            }
            return Ok(list);
        }
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            _productService.Delete();
            return Ok("Deleted Successfuly");
        }
    }
}
