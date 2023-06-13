using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShoppingCartSystem.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<CartService, CartImplementation>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
	
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

//app.MapControllers();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});


app.Run();
