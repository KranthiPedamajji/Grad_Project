//using Newtonsoft.Json.Serialization;

using Grad_Project.Models;
using Microsoft.EntityFrameworkCore;
using Grad_Project.Controllers;
using Grad_Project.AdventWorksModel;
using Grad_Project.Sakila;
using Grad_Project.NorthWindModels;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// Add services to the container.
//builder.Services.AddControllersWithViews().AddNewtonsoftJson(option => option.SerializerSettings.ContractResolver = new DefaultContractResolver());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<grad_projectContext>(optionsAction:_ =>
{
    _.UseMySQL(connectionString: "Server=localhost;Port=3306;Database=grad_project;User=root;Password=MysqlKranthi;");
});

builder.Services.AddDbContext<adventureworksContext>(optionsAction: _ =>
{
    _.UseMySQL(connectionString: "Server=localhost;Port=3306;Database=adventureworks;User=root;Password=MysqlKranthi;");
});

builder.Services.AddDbContext<sakilaContext>(optionsAction: _ =>
{
    _.UseMySQL(connectionString: "Server=localhost;Port=3306;Database=sakila;User=root;Password=MysqlKranthi;");
});

builder.Services.AddDbContext<northwindContext>(optionsAction: _ =>
{
    _.UseMySQL(connectionString: "Server=localhost;Port=3306;Database=northwinds;User=root;Password=MysqlKranthi;");
});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API Name", Version = "v1" });

    // Specify unique schema IDs for conflicting types
    options.CustomSchemaIds(type => type.FullName);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name");
    });
}

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapCustomerEndpoints();

app.Run();
