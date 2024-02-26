using EcommerceAPI.Features.Users.IoC;
using EcommerceAPI.Features.Users.Services.Create;
using EcommerceAPI.Features.Users.Services.Delete;
using EcommerceAPI.Features.Users.Services.Edit;
using EcommerceAPI.IoC;
using EcommerceAPI.Shared.Repos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options => options.AddPolicy("AllowCors", builder =>
{
    builder.SetIsOriginAllowed(_ => true)
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowCredentials();
}));

builder.Services.AddControllers();

builder.Services.AddInfrastructure(builder.Configuration);

//builder.Services.AddScoped<IBaseRepository<T>, BaseRepository<T>>();
// Add user feature.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
