using System;
using System.Linq;
using Xunit;

namespace ProjectEuler
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public class MultipleOf3And5Test
    {
        private int MultipleOf3And5(int n) => Enumerable.Range(1, n).Where(i => i % 3 == 0 || i % 5 == 0).Sum();

        [Fact]
        public void TestSomeOfTheseMultiples_NumberBelow10_Is33()
        {
            Assert.Equal(33, MultipleOf3And5(10));
        }
        
        [Fact]
        public void TestSomeOfTheseMultiples_NumberBelow1000_Is234168()
        {
            Assert.Equal(234168, MultipleOf3And5(1000));
        }
    }  
}
