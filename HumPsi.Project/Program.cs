using HumPsi.Application;
using HumPsi.Core.Repositories;
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

var app = builder.Build();

app.MapControllers();
app.UseRouting();
app.UseStaticFiles();
app.Run();