using ExpensesManagerAPI.Entities;
using ExpensesManagerAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Controllers
{
    public class ExpensesController
    {
        private readonly IExpensesTXsRepository repository;

        public ExpensesController(IExpensesTXsRepository repository)
        {
            this.repository = repository;
        }

        public List<Expenses> Get()
        {
            return repository.GetExpenseTransactions();
        }
    }
}
