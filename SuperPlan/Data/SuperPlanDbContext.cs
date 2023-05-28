using Microsoft.EntityFrameworkCore;
using SuperPlan.Models;

namespace SuperPlan.Data;

public class SuperPlanDbContext : DbContext
{
    public SuperPlanDbContext(DbContextOptions<SuperPlanDbContext> options)
        : base(options)
    {
    }

    public DbSet<Expense> Expenses { get; set; }
}