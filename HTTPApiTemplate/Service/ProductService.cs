using AutoMapper;
using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository.Product;
using HTTPApiTemplate.Service.Argument.Product;

namespace HTTPApiTemplate.Service;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _repository;

    public ProductService(IMapper mapper, IProductRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }


    public async Task<Product> CreateAsync(CreateProductArgument argument)
    {
        var mappedProduct = _mapper.Map<CreateProductArgument, Product>(argument);
        var result = await _repository.CreateAsync(mappedProduct);
        return result;
    }

    public async Task UpdateAsync(UpdateProductArgument argument)
    {
        var mappedProduct = _mapper.Map<UpdateProductArgument, Product>(argument);
        await _repository.UpdateAsync(mappedProduct);
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Product?> GetAsync(Guid id)
    {
        return await _repository.GetAsync(id);
    }
}