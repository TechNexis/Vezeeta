using API.ServicesExtension;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

#region Add services to the container

// Register API Controller
builder.Services.AddControllers();

// Register Required Services For Swagger In Extension Method
builder.Services.AddSwaggerServices();

#endregion

var app = builder.Build();

#region Configure the Kestrel pipeline

// -- Server Error Middleware (we catch it in class ExceptionMiddleware)
app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    // -- Add Swagger Middelwares In Extension Method
    app.UseSwaggerMiddleware();
}

// -- To Redirect Any Http Request To Https
app.UseHttpsRedirection();

app.MapControllers(); // -> we use this middleware to talk program that: your routing depend on route written on the controller

app.UseAuthentication(); // has token?

app.UseAuthorization();  // is allowed to enter this end point?

#endregion

app.Run();
