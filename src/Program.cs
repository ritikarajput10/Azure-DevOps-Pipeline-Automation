using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "✅ Azure DevOps Pipeline Automation (.NET App)");
app.MapGet("/status", () => Results.Ok("App is running successfully! 🚀"));

app.Run();
