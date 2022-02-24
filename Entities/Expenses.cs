using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Entities
{
    public class Expenses
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime txDate { get; set; }
    }
}
