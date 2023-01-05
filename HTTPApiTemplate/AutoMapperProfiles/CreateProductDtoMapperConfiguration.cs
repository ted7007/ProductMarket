using AutoMapper;
using HTTPApiTemplate.Dto.Input.Product;
using HTTPApiTemplate.Service.Argument.Product;

namespace HTTPApiTemplate.AutoMapperProfiles;

public class CreateProductDtoMapperConfiguration : Profile
{
    public CreateProductDtoMapperConfiguration()
    {
        CreateMap<CreateProductDto, CreateProductArgument>();
    }
}