using ExpensesManagerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Services
{
    public interface IExpensesTXsRepository
    {
        void AddExpense(Expense expense);

        Task<Expense> GetExpenseByID(int Id);

        Task<List<Expense>> GetExpenseTransactions();
    }
}
