

using Microsoft.EntityFrameworkCore;
using Task_2.Core.Customerss.Implementation;
using Task_2.Core.Customerss.Interface;
using Task_2.Core.Dashboards.Implementation;
using Task_2.Core.Dashboards.Interface;
using Task_2.Core.Excels.Implementation;
using Task_2.Core.Excels.Interface;
using Task_2.Core.Mappings.Implementation;
using Task_2.Core.Mappings.Interface;
using Task_2.Core.OrderItem.Implementation;
using Task_2.Core.OrderItem.Interface;
using Task_2.Core.Orders.Implementation;
using Task_2.Core.Orders.Interface;
using Task_2.Core.Products.Implementation;
using Task_2.Core.Products.Interface;
using Task_2.Core.Ratingss.Implementation;
using Task_2.Core.Ratingss.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection Configuration
var con = builder.Configuration.GetConnectionString("Dbconnection");
//Establishing relation between Dbcontext
builder.Services.AddDbContext<UserDbContext>(option => option.UseSqlServer(con));

//Customer
builder.Services.AddScoped<ICustomerCreator, CustomerCreator>();
builder.Services.AddScoped<ICustomerCountByMonth,  CustomerCountByMonth>();
builder.Services.AddScoped<ICustomerLogin,  CustomerLogin>();

builder.Services.AddScoped<IOrderCountByMonth,  OrderCountByMonth>();
builder.Services.AddScoped<ITopSellingProductByRatingCount, TopSellingProductByRatingCount>();
builder.Services.AddScoped<IOrderCountByQuantity, OrderCountByQuantity>();
builder.Services.AddScoped<IDashboardCommon , DashboardCommon>();

//Product
builder.Services.AddScoped<IProductCreator, ProductCreator>();

//Mapping
builder.Services.AddScoped<IMappingCreator, MappingCreator>();
builder.Services.AddScoped<IMappingUpdator, MappingUpdator>();

//Excel Upload,Get
builder.Services.AddScoped<IExcel, Excel>();
builder.Services.AddScoped<IExcelRetrival, ExcelRetrival>();


//Order
builder.Services.AddScoped<IOrderCreator, OrderCreator>();
builder.Services.AddScoped<IOrderUpdation, OrderUpdation>();
builder.Services.AddScoped<IOrderCreatorWithOrderItemsCreator , OrderCreatorWithOrderItemsCreator>();

//OrderItems
builder.Services.AddScoped<IOrderItemsCreator, OrderItemsCreator>();

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
