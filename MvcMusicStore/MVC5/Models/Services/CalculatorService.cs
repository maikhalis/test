using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5.Models.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}