using HTTPApiTemplate.Models;
using HTTPApiTemplate.Service.Argument.Product;

namespace HTTPApiTemplate.Service;

public interface IProductService
{
    Task<Product> CreateAsync(CreateProductArgument argument);

    Task UpdateAsync(UpdateProductArgument argument);

    Task<IEnumerable<Product>> GetAllAsync();

    Task<Product?> GetAsync(Guid id);

}