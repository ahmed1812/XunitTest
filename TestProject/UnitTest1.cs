using ConsoleTest;
using System;
using Xunit;
namespace TestProject

{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 },10)]
        public void Sum(int[] numbers, int expected)
        {
            // Arrange 
            InterViewTest num = new InterViewTest();
            // Act 
            int n = num.Sum(numbers);
            // Assert
            Assert.Equal(expected, n);

        }
        [Theory]
        [InlineData(5,10, 50)]
        public void Multiply(int a,int b, int expected)
        {
            // Arrange 
            InterViewTest num = new InterViewTest();
            // Act 
            int n = num.Multiply(a,b);
            // Assert
            Assert.Equal(expected, n);

        }
        [Theory]
        [InlineData(new int[] { 1, 2, 5, 4 }, 3)]
        public void DiffIndex(int[] numbers, int expected)
        {
            InterViewTest num = new InterViewTest();
            int n = num.DiffIndex(numbers);
            Assert.Equal(expected, n);
        }
    }
}
