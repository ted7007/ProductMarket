using AutoMapper;
using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository.Argument;

namespace HTTPApiTemplate.AutoMapperProfiles;

public class ProductMapperConfiguration : Profile
{
    public ProductMapperConfiguration()
    {
        CreateMap<Product, CreateProductArgument>();
        CreateMap<CreateProductArgument, Product>();
        CreateMap<Product, UpdateProductArgument>();
        CreateMap<UpdateProductArgument, Product>();
    }
}