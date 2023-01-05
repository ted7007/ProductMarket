using AutoMapper;
using HTTPApiTemplate.Dto.Input.Product;
using HTTPApiTemplate.Dto.Output.Product;
using HTTPApiTemplate.Models;
using HTTPApiTemplate.Service;
using HTTPApiTemplate.Service.Argument.Product;
using Microsoft.AspNetCore.Mvc;

namespace HTTPApiTemplate.Controller;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;
    private readonly IMapper _mapper;

    public ProductController(IProductService service, IMapper mapper)
    {
        _mapper = mapper;
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<ProductDto>> CreateAsync(CreateProductDto argument)
    {
        var mappedArgument = _mapper.Map<CreateProductDto, CreateProductArgument>(argument);
        var result = await _service.CreateAsync(mappedArgument);
        var mappedResult = _mapper.Map<Product, ProductDto>(result);
        return new OkObjectResult(mappedResult);
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllAsync()
    {
        var products = await _service.GetAllAsync();
        var mappedProducts = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
        return new OkObjectResult(mappedProducts);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> GetAsync(Guid id)
    {
        var product = await _service.GetAsync(id);
        var mappedProduct = _mapper.Map<Product, ProductDto>(product); 
        return new OkObjectResult(mappedProduct);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateAsync(UpdateProductDto argument)
    {
        var mappedArgument = _mapper.Map<UpdateProductDto, UpdateProductArgument>(argument);
        await _service.UpdateAsync(mappedArgument);
        return new OkResult();
    }
}