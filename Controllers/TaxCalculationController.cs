using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace microapi.Controllers
{
    public class TaxBody
    {
        public double TaxAmount{
            get;set;
        }
         public string Country{
            get;set;
        }

    }
    
    // base controller
    [ApiController]
    [Route("[controller]")]
    public class TaxCalculationController : ControllerBase
    {
        private readonly ILogger<TaxCalculationController> _logger;

        public TaxCalculationController(ILogger<TaxCalculationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Welcome To Global Tax Calculations";
        }

        [HttpGet("{SalaryAmount}/{Country}")]
        public TaxCalculation Get(double SalaryAmount, string Country)
        {
            double TaxAmount;
            if (SalaryAmount <= 20000)
            {
                TaxAmount = SalaryAmount * 0.2;
            }
            else
                TaxAmount = SalaryAmount * 0.3;

            return new TaxCalculation
            {
                EmployeeSalary = SalaryAmount,
                EmployeeTax = TaxAmount,

            };
        }
        //[HttpPost]
        //public IActionResult PostTodoItem(TaxBody body)
        //{
        //    //var tbody = JsonConvert.DeserializeObject<TaxBody>(body.ToString());

        //    var tbody = body;

        //    double TaxAmount;
        //    if (tbody.TaxAmount <= 20000)
        //    {
        //        TaxAmount = tbody.TaxAmount * 0.2;
        //    }
        //    else
        //        TaxAmount = tbody.TaxAmount * 0.3;

        //    return new TaxCalculation
        //    {
        //        EmployeeSalary = tbody.TaxAmount,
        //        EmployeeTax = TaxAmount,
        //        Country = tbody.Country

        //    };
        //}
       
    }
}
