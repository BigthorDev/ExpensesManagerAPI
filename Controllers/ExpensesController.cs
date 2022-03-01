using ExpensesManagerAPI.Entities;
using ExpensesManagerAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesManagerAPI.Controllers
{
    [Route("api/expenses")]
    [ApiController]
    public class ExpensesController: ControllerBase
    {
        private readonly IExpensesTXsRepository repository;
        private readonly ILogger<ExpensesController> logger;

        public ExpensesController(IExpensesTXsRepository repository, ILogger<ExpensesController>logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet]
        [HttpGet("list")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<List<Expense>>> Get()
        {
            logger.LogInformation("Getting all expenses");
            return await repository.GetExpenseTransactions();
        }

        [HttpGet("{Id:int}", Name ="getExpense")]
        public async Task<ActionResult<Expense>> Get(int Id)
        {
            var expense = await repository.GetExpenseByID(Id);
            if (expense != null)
                return expense;
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody]Expense expense)
        {
            repository.AddExpense(expense);
            return new CreatedAtRouteResult("getExpense", new { Id = expense.Id }, expense);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Expense expense)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }

    }
}
