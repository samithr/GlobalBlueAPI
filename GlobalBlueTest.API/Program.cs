using GlobalBlueTest.API.Middlewares;
using GlobalBlueTest.Repository.Contracts;
using GlobalBlueTest.Repository.Repos;
using GlobalBlueTest.Service.Contracts;
using GlobalBlueTest.Service.Services;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200");
                      });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Repository DI

builder.Services.AddScoped<ICountryRepository, CountryRepository>();

#endregion

#region Services DI

builder.Services.AddScoped<ICountryService, CountryService>();

#endregion


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();
app.UseMiddleware(typeof(ExceptionHandlingMiddleware));
app.UseAuthorization();

app.MapControllers();

app.Run();
