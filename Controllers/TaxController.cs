using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        // GET: api/<TaxController>
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public IEnumerable<string> GetTaxCountries()
        {
            return new string[] { "CAN-1", "USA-2", "IND-3"};
        }

        // GET api/<TaxController>/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{SalaryAmount}")]
        public double GetTaxes(double SalaryAmount)
        {
            double TaxAmount;
            if (SalaryAmount <= 20000)
            {
                TaxAmount = SalaryAmount * 0.2;
            }
            else
                TaxAmount = SalaryAmount * 0.3;


            return TaxAmount;
        }

        // POST api/<TaxController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaxController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaxController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
