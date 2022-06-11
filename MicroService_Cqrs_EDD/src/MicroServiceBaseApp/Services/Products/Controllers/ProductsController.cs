using System.Net;
using Microsoft.AspNetCore.Mvc;
using Products.Entities;
using Products.Repositories.Interfaces;

namespace Products.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        #region Variables
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductsController> _logger;
        #endregion


        #region Constructor
        public ProductsController(IProductRepository productRepository, ILogger<ProductsController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        #endregion

        #region Crud Actions

        [HttpGet]
        [ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _productRepository.GetProducts();
            return Ok(products);

        }


        [HttpGet("{id:length(36)}", Name = "GetProduct")]
        [ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var product = await _productRepository.GetProduct(id);
            if (product == null)
            {
                _logger.LogError($"Product with id : {id} is not found");
                return NotFound();
            }
            return Ok(product);

        }



        [HttpPost]
        [ProducesResponseType(typeof(Product), (int)HttpStatusCode.Created)]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {
            await _productRepository.Create(product);
            return CreatedAtRoute("GetProduct", new { id = product.Id }, product);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Product), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            return Ok(await _productRepository.Update(product));
        }


        [HttpDelete("{id:length(36)}")]
        public async Task<IActionResult> DeleteProductById(Guid id){
            return Ok(await _productRepository.Delete(id));
        }



        #endregion

    }
}