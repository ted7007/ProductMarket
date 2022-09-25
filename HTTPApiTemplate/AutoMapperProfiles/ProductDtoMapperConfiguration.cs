using AutoMapper;
using HTTPApiTemplate.Dto.Input.Product;
using HTTPApiTemplate.Dto.Output.Product;
using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository.Argument;

namespace HTTPApiTemplate.AutoMapperProfiles;

public class ProductDtoMapperConfiguration : Profile
{
    public ProductDtoMapperConfiguration()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<ProductDto, Product>();
        
        CreateMap<CreateProductArgument, CreateProductDto>();
        CreateMap<CreateProductDto, CreateProductArgument>();
        CreateMap<UpdateProductArgument, UpdateProductDto>();
        CreateMap<UpdateProductDto, UpdateProductArgument>();
        
    }
}