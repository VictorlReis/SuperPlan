using Microsoft.EntityFrameworkCore;
using SuperPlan.Data;
using SuperPlan.Data.Repository;
using SuperPlan.Models;

public class ExpenseRepository : IExpenseRepository
{
    private readonly SuperPlanDbContext _context;

    public ExpenseRepository(SuperPlanDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Expense>> GetExpensesAsync()
    {
        return await _context.Expenses.ToListAsync();
    }

    public async Task<Expense> GetExpenseByIdAsync(int id)
    {
        return await _context.Expenses.FindAsync(id);
    }

    public async Task AddExpenseAsync(Expense expense)
    {
        await _context.Expenses.AddAsync(expense);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateExpenseAsync(Expense expense)
    {
        _context.Expenses.Update(expense);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteExpenseAsync(int id)
    {
        var expense = await _context.Expenses.FindAsync(id);
        if (expense != null)
        {
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
        }
    }
}
