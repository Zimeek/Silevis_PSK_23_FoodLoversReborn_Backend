using Silevis_PSK_23_FoodLoversReborn_Backend.API.Extensions;
using Silevis_PSK_23_FoodLoversReborn_Backend.Infrastructure.DataAccess;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.SetupApplicationDbContext(builder.Configuration);
builder.Services.SetupMediatR();
builder.Services.SetupCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors("_localorigin");

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var applicationDbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await ApplicationDbContextSeeder.SeedAsync(applicationDbContext);
}

app.Run();