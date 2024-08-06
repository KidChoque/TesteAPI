using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAPIProduct.Domains;
using TesteAPIProduct.Interface;
using TesteAPIProduct.Migrations;
using TesteAPIProduct.Repositories;

namespace TesteAPIProduct.Cotrollers
{
    [Route("api/[controller]")]
    [ApiController]


    public class ProductController : ControllerBase
    {
        public IProductRepository _productRepository {  get; set; }

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_productRepository.GetProducts());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]

        public IActionResult Post(Products product)
        {
            try
            {
                _productRepository.Post(product);

                return StatusCode(201, product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    
    }
}
