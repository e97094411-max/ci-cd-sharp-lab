using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
