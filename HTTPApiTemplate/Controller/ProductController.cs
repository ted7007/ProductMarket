using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository;
using HTTPApiTemplate.Repository;
using HTTPApiTemplate.Repository.Argument;
using Microsoft.AspNetCore.Mvc;

namespace HTTPApiTemplate.Controller;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IRepository<Product, CreateProductArgument, UpdateProductArgument> _service;

    public ProductController(IRepository<Product, CreateProductArgument, UpdateProductArgument> service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<Product> Create(CreateProductArgument argument)
    {

        return new OkObjectResult(_service.Create(argument));
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        return new OkObjectResult(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        return new OkObjectResult(_service.Get(id));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _service.Delete(id);
        return new OkResult();
    }

    [HttpPut]
    public IActionResult Update(UpdateProductArgument argument)
    {
        _service.Update(argument);
        return new OkResult();
    }
}