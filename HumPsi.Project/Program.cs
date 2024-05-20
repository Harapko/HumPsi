using HumPsi.Application;
using HumPsi.Core.Repositories;
using HumPsi.Data.MsSql.Abstraction.Headline;
using HumPsi.Data.MsSql.Abstraction.Photo;
using HumPsi.DataAccess;
using HumPsi.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(AppDbContext)));
});

builder.Services.AddScoped<ISectionService, SectionService>();
builder.Services.AddScoped<ISectionsRepository, SectionsRepository>();

builder.Services.AddScoped<IHeadlineService, HeadlinesService>();
builder.Services.AddScoped<IHeadlinesRepository, HeadlinesRepository>();

builder.Services.AddScoped<IHeadlinesPhotoService, HeadlinesHeadlinesPhotoService>();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder.WithOrigins(builder.Configuration.GetSection("AllowedOrigins").Get<string[]>());
    });
});


var app = builder.Build();

app.MapControllers();
app.UseRouting();
app.UseCors();
app.UseStaticFiles();
app.Run();