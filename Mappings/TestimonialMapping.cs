using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.TestimonialDtos;

namespace BabyCareProject.Mappings
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
              CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
              CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
              CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
        }
    }
}
