using Microsoft.EntityFrameworkCore;
using OnlineCourses.Domain;
using OnlineCourses.Infrastructure.Persistence;
using OnlineCourses.Infrastructure.Repositories;
using OnlineCourses.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.Reflection;
using MediatR;
using OnlineCourses.Core.Profiles;
using OnlineCourses.Core.Contracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMvc();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped(typeof(IAsyncRepo<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ICourseRepo), typeof(CourseRepository));
builder.Services.AddScoped(typeof(ICategoriesRepo), typeof(CategoryRepository));

builder.Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OnlineCoursesDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineCourseConnectionString")));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
