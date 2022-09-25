using AutoMapper;
using HTTPApiTemplate.Dto.Input.Product;
using HTTPApiTemplate.Dto.Output.Product;
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
    private readonly IRepository<Product, CreateProductArgument, UpdateProductArgument> _context;
    private readonly IMapper _mapper;

    public ProductController(IRepository<Product, CreateProductArgument, UpdateProductArgument> context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    [HttpPost]
    public ActionResult<ProductDto> Create(CreateProductDto argument)
    {
        var mappedArgument = _mapper.Map<CreateProductDto, CreateProductArgument>(argument);
        var result = _context.Create(mappedArgument);
        var mappedResult = _mapper.Map<Product, ProductDto>(result);
        return new OkObjectResult(mappedResult);
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<ProductDto>> GetAll()
    {
        var products = _context.GetAll();
        var mappedProducts = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        return new OkObjectResult(mappedProducts);
    }

    [HttpGet("{id}")]
    public ActionResult<ProductDto> Get(Guid id)
    {
        var product = _context.Get(id);
        var mappedProduct = _mapper.Map<Product, ProductDto>(product); 
        return new OkObjectResult(mappedProduct);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        _context.Delete(id);
        return new OkResult();
    }

    [HttpPut]
    public ActionResult Update(UpdateProductDto argument)
    {
        var mappedArgument = _mapper.Map<UpdateProductDto, UpdateProductArgument>(argument);
        _context.Update(mappedArgument);
        return new OkResult();
    }
}