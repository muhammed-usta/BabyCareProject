using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.ProductDtos;

namespace BabyCareProject.Mappings
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
                CreateMap<Product, ResultProductDto>().ReverseMap();
                CreateMap<Product, UpdateProductDto>().ReverseMap();
                CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}
