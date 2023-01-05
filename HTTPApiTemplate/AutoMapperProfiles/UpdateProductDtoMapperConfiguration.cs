using AutoMapper;
using HTTPApiTemplate.Dto.Input.Product;
using HTTPApiTemplate.Service.Argument.Product;

namespace HTTPApiTemplate.AutoMapperProfiles;

public class UpdateProductDtoMapperConfiguration : Profile
{
    public UpdateProductDtoMapperConfiguration()
    {
        CreateMap<UpdateProductDto, UpdateProductArgument>();
    }
}