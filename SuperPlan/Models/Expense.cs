namespace SuperPlan.Models;

public record Expense(int Id, string Description, decimal Amount, DateTime Date, string PaymentMethod, string Category, int Month);