using SuperPlan.Data.Repository;
using SuperPlan.Models;

namespace SuperPlan.Services
{
    public class ExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<List<Expense>> GetExpensesAsync()
        {
            return (await _expenseRepository.GetExpensesAsync()).ToList();
        }

        public async Task AddExpenseAsync(Expense expense)
        {
            await _expenseRepository.AddExpenseAsync(expense);
        }

        public async Task EditExpenseAsync(Expense expense)
        {
            await _expenseRepository.UpdateExpenseAsync(expense);
        }

        public async Task DeleteExpenseAsync(int id)
        {
            await _expenseRepository.DeleteExpenseAsync(id);
        }
    }
}