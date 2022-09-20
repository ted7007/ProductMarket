using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository;
using HTTPApiTemplate.Repository.Argument;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace HTTPApiTemplate.Repository;

public class ProductService : IRepository<Product, CreateProductArgument, UpdateProductArgument>
{
                                  
    public List<Product> Products { get; set; }

    public ProductService()
    {
        Products = new List<Product>();
    }
    public Product Create(CreateProductArgument product)
    {
        Products.Add(new Product());
        
        return Products.Last();
    }

    public IEnumerable<Product> GetAll()
    {
        return Products;
    }

    public Product Get(Guid id)
    {
        return Products.Find(p => p.Id == id) ?? throw new InvalidOperationException();
    }

    public void Delete(Guid id)
    {
        Products.Remove(Get(id));
    }

    public void Update(UpdateProductArgument product)
    {
        throw new NotImplementedException();
    }
}