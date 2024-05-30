using HumPsi.Application;
using HumPsi.Core.Repositories;
using HumPsi.Data.MsSql.Abstraction.Headline;
using HumPsi.Data.MsSql.Abstraction.Photo;
using HumPsi.DataAccess;
using HumPsi.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
    options.AddDefaultPolicy(builder => {
        builder.WithOrigins("http://localhost:4200");
        builder.WithMethods("GET", "POST");
        builder.AllowAnyHeader();
    });
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseRouting();
app.UseStaticFiles();
app.UseCors();
app.Run();
