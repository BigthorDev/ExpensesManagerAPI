using ExpensesManagerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Services
{
    public interface IExpensesTXsRepository
    {
        List<Expenses> GetExpenseTransactions();
    }
}
