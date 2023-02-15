using MES.API.Filter;
using MES.EFCors;
using MES.IRespository;
using MES.IService;
using MES.Respository;
using MES.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers().AddJsonOptions(p => p.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddDbContext<MyDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlStr")));

builder.Services.AddCors(x=>x.AddPolicy("any",op=>op.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
//Æô¶¯¹ýÂËÆ÷
builder.Services.AddMvc(op =>
{
    op.Filters.Add(typeof(ExceptionFilter));
});


builder.Services.AddScoped<IMeterielRespository, MeterielRespository>();
builder.Services.AddScoped<IMeterielService, MeterielService>();

builder.Services.AddScoped<IProductionRespository, ProductionRespository>();
builder.Services.AddScoped<IProductionService, ProductionService>();

builder.Services.AddScoped<IDeviceRespository, DeviceRespository>();
builder.Services.AddScoped<IDeviceService, DeviceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("any");

}

app.UseAuthorization();

app.MapControllers();

app.Run();
