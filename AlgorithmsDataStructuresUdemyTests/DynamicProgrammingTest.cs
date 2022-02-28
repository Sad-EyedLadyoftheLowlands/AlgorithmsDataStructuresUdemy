using AlgorithmsDataStructuresUdemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsDataStructuresUdemyTests
{
    public class DynamicProgrammingTest
    {
        [Fact]
        public void RecursiveFibonacci_BaseCaseReturns()
        {
            var x = new DynamicProgramming();
            var result = x.RecursiveFibonacci(1);
            Assert.Equal(1, result);
        }
    }
}
