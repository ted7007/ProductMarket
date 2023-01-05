using HTTPApiTemplate.Models;

namespace HTTPApiTemplate.Repository.Product;

public interface IProductRepository
{ 
    Task<Models.Product> CreateAsync(Models.Product product);
    
    Task<IEnumerable<Models.Product>> GetAllAsync();

    Task<Models.Product?> GetAsync(Guid id);

    Task RemoveAsync(Guid id);

    Task UpdateAsync(Models.Product product);
}