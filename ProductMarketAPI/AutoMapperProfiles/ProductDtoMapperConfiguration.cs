using AutoMapper;
using ProductMarketAPI.Dto.Input.Product;
using ProductMarketAPI.Dto.Output.Product;
using ProductMarketAPI.Models;

namespace ProductMarketAPI.AutoMapperProfiles;

public class ProductDtoMapperConfiguration : Profile
{
    public ProductDtoMapperConfiguration()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();
        
        
    }
}