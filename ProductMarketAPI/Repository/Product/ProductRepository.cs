﻿using Microsoft.EntityFrameworkCore;

namespace ProductMarketAPI.Repository.Product;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationContext _context;

    public ProductRepository(ApplicationContext context)
    {
        _context = context;
    }
    public async Task<Models.Product> CreateAsync(Models.Product product)
    {
        var res = await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        
        return res.Entity;
    }

    public async Task<IEnumerable<Models.Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Models.Product?> GetAsync(Guid id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task RemoveAsync(Guid id)
    {
        var productForRemove = await GetAsync(id) ?? throw new InvalidOperationException();
        _context.Products.Remove(productForRemove);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Models.Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }
}