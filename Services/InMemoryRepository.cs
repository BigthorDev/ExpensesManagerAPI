using ExpensesManagerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Services
{
    public class InMemoryRepository : IExpensesTXsRepository
    {
        private List<Expenses> _transactions;
        
        public InMemoryRepository()
        {
            _transactions = new List<Expenses>()
            {
                new Expenses(){ Name = "Morgage", Amount=790, txDate=DateTime.Now },
                new Expenses(){ Name = "Vet", Amount=500, txDate=DateTime.Now, Description="The strange case of Mawi Button" },
            };
        }

        public List<Expenses> GetExpenseTransactions()
        {
            return _transactions;
        }
    }
}
