using System.Globalization;
using System.Text.Json;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors();

builder.Services.Configure<JsonOptions>(options =>
    {
options.SerializerOptions.PropertyNamingPolicy=JsonNamingPolicy.SnakeCaseLower;
    }
);

var app = builder.Build();

app.UseCors(options => {
    options.AllowAnyOrigin()
        .WithMethods("GET")
        .AllowAnyHeader();
});


app.MapGet("/", () =>
{
    string isoDateTime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
    return Results.Json(new
    {
        email = "marvellousboun@gmail.com",
        currentDatetime = isoDateTime,
        githubUrl="https://github.com/lankiman/hng-task-0"
    });
});

app.Run();
