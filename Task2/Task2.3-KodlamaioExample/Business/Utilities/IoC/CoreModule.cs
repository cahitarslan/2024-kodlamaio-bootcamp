using Business.Abstract;
using Business.Concrete;
using Business.Validators;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Repositories;
using Entities.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Utilities.IoC;

public class CoreModule : ICoreModule
{
    public void Load(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICategoryService, CategoryManager>();
        serviceCollection.AddScoped<ICourseService, CourseManager>();
        serviceCollection.AddScoped<IInstructorService, InstructorManager>();

        serviceCollection.AddScoped<ICategoryDal, EfCategoryDal>();
        serviceCollection.AddScoped<ICourseDal, EfCourseDal>();
        serviceCollection.AddScoped<IInstructorDal, EfInstructorDal>();

        serviceCollection.AddTransient<IValidator<Category>, CategoryValidator>();
        serviceCollection.AddTransient<IValidator<Course>, CourseValidator>();
        serviceCollection.AddTransient<IValidator<Instructor>, InstructorValidator>();
    }
}
