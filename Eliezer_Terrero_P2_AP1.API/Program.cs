
using Eliezer_Terrero_P2_AP1.API.DAL;
using Microsoft.EntityFrameworkCore;

namespace Eliezer_Terrero_P2_AP1.API
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
            builder.Services.AddSwaggerGen();
            var conStr = builder.Configuration.GetConnectionString("conStr");
            builder.Services.AddDbContext<Contexto>(op => op.UseSqlite(conStr));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(op =>
            {
                op.AllowAnyMethod();
                op.AllowAnyHeader();
                op.AllowAnyOrigin();
            });
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
