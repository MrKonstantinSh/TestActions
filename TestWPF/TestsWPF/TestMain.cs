using System;
using TestWPF;
using Xunit;

namespace TestsWPF
{
    public class TestMain
    {
        [Fact]
        public void Test_3_4_Result_7()
        {
            int a = 3;
            int b = 4;
            int expected = 7;

            int result = MainWindow.Test(a, b);
            
            Assert.Equal(expected, result);
        }
    }
}