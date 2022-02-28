using ExpensesManagerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Services
{
    public class InMemoryRepository : IExpensesTXsRepository
    {
        private List<Expense> _transactions;
        
        public InMemoryRepository()
        {
            _transactions = new List<Expense>()
            {
                new Expense(){ Id = 1, Name = "Morgage", Amount=790, txDate=DateTime.Now },
                new Expense(){ Id = 2, Name = "Vet", Amount=500, txDate=DateTime.Now, Description="The strange case of Mawi Button" },
            };
        }

        public async Task<List<Expense>> GetExpenseTransactions()
        {
            return _transactions;
        }

        public async Task<Expense> GetExpenseByID(int Id)
        {
            return _transactions.FirstOrDefault(x => x.Id == Id);
        }

        public void AddExpense(Expense expense)
        {
            expense.Id = _transactions.Max(x => x.Id) + 1;
            _transactions.Add(expense);        
        }
    }
}
