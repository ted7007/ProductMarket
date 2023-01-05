using AutoMapper;
using ProductMarketAPI.Dto.Input.Product;
using ProductMarketAPI.Service.Argument.Product;

namespace ProductMarketAPI.AutoMapperProfiles;

public class CreateProductDtoMapperConfiguration : Profile
{
    public CreateProductDtoMapperConfiguration()
    {
        CreateMap<CreateProductDto, CreateProductArgument>();
    }
}