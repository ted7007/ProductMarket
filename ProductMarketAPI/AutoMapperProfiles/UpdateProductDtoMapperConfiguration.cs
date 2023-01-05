using AutoMapper;
using ProductMarketAPI.Dto.Input.Product;
using ProductMarketAPI.Service.Argument.Product;

namespace ProductMarketAPI.AutoMapperProfiles;

public class UpdateProductDtoMapperConfiguration : Profile
{
    public UpdateProductDtoMapperConfiguration()
    {
        CreateMap<UpdateProductDto, UpdateProductArgument>();
    }
}