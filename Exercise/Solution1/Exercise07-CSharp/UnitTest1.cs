using Exercise06_CSharp;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Exercise07_CSharp
{
    public class UnitTest1
    {
        //testing for string input with commas and spaces
        [Fact]
        public void Test1()
        {
            int expected = 3;
            int result = 0;
            string[] input = { "1, 2, 4, 5" };
            result = Exercise06.FindSmallestNumber(input);
            Assert.Equal(3, result);

        }
        //testing for numbers or input in array
        [Fact]
        public void Test2() 
        {
            int expected = 1;
            int result = 1;
            string[] input = { "2, 3, 4, 5" };
            result = Exercise06.FindSmallestNumber(input);
            Assert.Equal(1, result);
        }
        //testing if it will stort and removes the s
        [Fact]
        public void Test3()
        {
            int expected = 4;
            int result = 4;

            string[] input = { "5, 1, 3, 2" };
            result = Exercise06.FindSmallestNumber(input);
            Assert.Equal(4, result);
        }
        //testing sequentce of numbers
        [Fact]
        public void Test4()
        {
            int expected = 6;
            int result = 6;
            int[] input = { 1, 2, 3, 4, 5 };
            result = Exercise06.FindSmallestNumber(input);
            Assert.Equal(3, result);
        }
        //testing for arrays
        [Fact]
        public void Test5()
        {
            int expected = 1;
            int result = 1;
            int[] input = { 2, 3, 4, 5 };
            result = Exercise06.FindSmallestNumber(input);
            Assert.Equal(1, result);
        }


    }
}



