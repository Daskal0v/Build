using System.Reflection;
using Build.Infrastructure.Persistence.DbContexts;
using Build.Web.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel((context, options) =>
{
    options.AddServerHeader = false;

    /* Because not all routers, firewalls, and proxies properly support HTTP/3, HTTP/3 should be configured together with HTTP/1.1 and HTTP/2. This can be done by specifying HttpProtocols.Http1AndHttp2AndHttp3 as an endpoint's supported protocols. */

    //options.ListenAnyIP(5000, listenOptions =>
    //{
    //    listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http1AndHttp2AndHttp3;
    //    listenOptions.UseHttps();
    //});
});

// Add services to the container.
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddHealthChecks();

builder.Services.AddGrpc().AddJsonTranscoding();
builder.Services.AddGrpcSwagger();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1",
        new OpenApiInfo { Title = "Build API", Version = "v1" });
});


builder.Services.AddDbContext<ApplicationDbContext>(options => options
               .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Build API V1");
        c.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseHttpsRedirection();
}

app.UseRouting();
//app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health/startup");
    endpoints.MapHealthChecks("/healthz");
    endpoints.MapHealthChecks("/ready");
});

app.MapGrpcService<ProjectService>();
app.Run();
