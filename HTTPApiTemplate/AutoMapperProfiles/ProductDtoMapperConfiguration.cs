using AutoMapper;
using HTTPApiTemplate.Dto.Input.Product;
using HTTPApiTemplate.Dto.Output.Product;
using HTTPApiTemplate.Models;

namespace HTTPApiTemplate.AutoMapperProfiles;

public class ProductDtoMapperConfiguration : Profile
{
    public ProductDtoMapperConfiguration()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();
        
        
    }
}