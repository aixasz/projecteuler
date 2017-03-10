using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ProjectEuler.EvenFibonacciNumbers
{

    public class EvenFibonacciNumbersTest
    {
        private int Fibonacci(int n) => ((n == 0) || (n == 1)) ? n : Fibonacci(n - 1) + Fibonacci(n - 2);

        [Fact]
        public void TestEvenFibonacciNumbers_LastNumberOf10Terms_Is55()
        {
            Assert.Equal(55, Fibonacci(10));
        }

        [Fact]
        public void TestEvenFibonacciNumbers_LastNumberOf20Terms_Is6765()
        {  
            Assert.Equal(6765, Fibonacci(20));
        }
    }   
}
