
using Business.Utilities.IoC;
using Microsoft.OpenApi.Models;
using WebApi.Extensions;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(options =>
            {
                options.SupportNonNullableReferenceTypes();
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "kodlama.io - Example API", Version = "v1" });
            });

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddDependencyResolvers(new ICoreModule[]
            {
                new CoreModule()
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
