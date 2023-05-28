using Microsoft.EntityFrameworkCore;
using SuperPlan.Data;
using SuperPlan.Data.Repository;
using SuperPlan.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddDbContext<SuperPlanDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.BuildServiceProvider().GetService<SuperPlanDbContext>()?.Database.Migrate();

builder.Services.AddScoped<ExpenseService>();
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();