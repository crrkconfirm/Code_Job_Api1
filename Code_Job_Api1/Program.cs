
using Code_Job_Api1.Models;
using Code_Job_Api1.Repository;
using Code_Job_Api1.Repository.GenericRepository;

namespace Code_Job_Api1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Cors("CORSPOLICY");
            builder.Services.AddScoped<IGenericRepository<Student>, GenericRepository<Student>>();
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("CORSPOLICY");
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}