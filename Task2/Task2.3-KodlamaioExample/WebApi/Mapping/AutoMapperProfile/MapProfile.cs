using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace WebApi.Mapping.AutoMapperProfile;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<CategoryAddDto, Category>();
        CreateMap<CategoryUpdateDto, Category>();
        CreateMap<CategoryGetDto, Category>();

        CreateMap<Category, CategoryAddDto>();
        CreateMap<Category, CategoryUpdateDto>();
        CreateMap<Category, CategoryGetDto>();


        CreateMap<Instructor, InstructorAddDto>();
        CreateMap<Instructor, InstructorUpdateDto>();
        CreateMap<Instructor, InstructorGetDto>();

        CreateMap<InstructorAddDto, Instructor>();
        CreateMap<InstructorUpdateDto, Instructor>();
        CreateMap<InstructorGetDto, Instructor>();


        CreateMap<Course, CourseAddDto>();
        CreateMap<Course, CourseUpdateDto>();
        CreateMap<Course, CourseGetDto>();

        CreateMap<CourseAddDto, Course>();
        CreateMap<CourseUpdateDto, Course>();
        CreateMap<CourseGetDto, Course>();
    }
}
