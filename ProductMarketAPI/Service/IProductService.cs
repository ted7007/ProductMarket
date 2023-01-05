using ProductMarketAPI.Models;
using ProductMarketAPI.Service.Argument.Product;

namespace ProductMarketAPI.Service;

public interface IProductService
{
    Task<Product> CreateAsync(CreateProductArgument argument);

    Task UpdateAsync(UpdateProductArgument argument);

    Task<IEnumerable<Product>> GetAllAsync();

    Task<Product?> GetAsync(Guid id);

}