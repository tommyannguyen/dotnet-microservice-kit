using AutoMapper;
using category.Domain.Models;

namespace category.Infrastructure.ExampleService
{
    public class ExampleProfile : Profile
    {
        public ExampleProfile()
        {
            CreateMap<ExampleEntity, Example>()
                .ReverseMap();
        }
    }
}