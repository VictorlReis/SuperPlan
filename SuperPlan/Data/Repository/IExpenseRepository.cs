using SuperPlan.Models;

namespace SuperPlan.Data.Repository;

public interface IExpenseRepository
{
    Task<IEnumerable<Expense>> GetExpensesAsync();
    Task<Expense> GetExpenseByIdAsync(int id);
    Task AddExpenseAsync(Expense expense);
    Task UpdateExpenseAsync(Expense expense);
    Task DeleteExpenseAsync(int id);
}