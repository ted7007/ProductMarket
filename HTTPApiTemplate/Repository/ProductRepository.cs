using AutoMapper;
using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository;
using HTTPApiTemplate.Repository.Argument;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace HTTPApiTemplate.Repository;

public class ProductService : IRepository<Product, CreateProductArgument, UpdateProductArgument>
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;

    public ProductService(ApplicationContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }
    public Product Create(CreateProductArgument argument)
    {
        //todo async methods
        var res = _context.Products.Add(_mapper.Map<CreateProductArgument, Product>(argument));
        _context.SaveChanges();
        
        return res.Entity;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product Get(Guid id)
    {
        return _context.Products.Find(id) ?? throw new InvalidOperationException();
    }

    public void Delete(Guid id)
    {
        _context.Products.Remove(Get(id));
        _context.SaveChanges();
    }

    public void Update(UpdateProductArgument argument)
    {
        _context.Products.Update(_mapper.Map<UpdateProductArgument, Product>(argument));
        _context.SaveChanges();
    }
}