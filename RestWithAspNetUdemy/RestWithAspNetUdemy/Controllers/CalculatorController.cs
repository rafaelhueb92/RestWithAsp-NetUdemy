using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNetUdemy.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        
        // GET api/values/5
        [HttpGet("{FirstNumber}/{SecondNumber}")]
        public IActionResult Sum(string FirstNumber, string SecondNumber)
        {

            if (IsNumeric(FirstNumber) && IsNumeric(SecondNumber))
            {

                var sum = ConvertToDecimal(FirstNumber) + ConvertToDecimal(SecondNumber);

                return Ok(sum.ToString());

            }

            return BadRequest("Invalid Input");

        }

        private decimal ConvertToDecimal(string Number)
        {

            decimal decimalvalue;

            if (decimal.TryParse(Number, out decimalvalue)) return decimalvalue;

            return 0;

        }

        private bool IsNumeric(string Number)
        {

            double number;

            bool isNumber = double.TryParse(Number, System.Globalization.NumberStyles.Any,
                                                    System.Globalization.NumberFormatInfo.InvariantInfo,
                                                    out number);

            return isNumber;

        }

    }

}