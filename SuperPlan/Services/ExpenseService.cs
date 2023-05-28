using SuperPlan.Models;

namespace SuperPlan.Services;

public class ExpenseService
{
    private List<Expense> Expenses { get; } = new();

    public Task<List<Expense>> GetExpensesAsync() => Task.FromResult(Expenses);

    public Task AddExpenseAsync(Expense expense)
    {
        Expenses.Add(expense);
        return Task.CompletedTask;
    }

    public Task EditExpenseAsync(Expense expense)
    {
        var index = Expenses.FindIndex(x => x.Id == expense.Id);
        if (index != -1)
            Expenses[index] = expense;
        return Task.CompletedTask;
    }

    public Task DeleteExpenseAsync(int id)
    {
        var expense = Expenses.Find(x => x.Id == id);
        if (expense != null)
            Expenses.Remove(expense);
        return Task.CompletedTask;
    }
}
