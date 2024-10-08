namespace _82_PascalsTriangle.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
        }
    }
    public class PascalsTriangleTests
    {
        [Fact]
        public void Zero_rows()
        {
            Assert.Empty(PascalsTriangle.Calculate(0));
        }
        [Fact]
        public void Single_row()
        {
            var expected = new[]
            {
            new[] { 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(1));
        }
        [Fact]
        public void Two_rows()
        {
            var expected = new[]
            {
            new[] { 1 },
            new[] { 1, 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(2));
        }
        [Fact]
        public void Three_rows()
        {
            var expected = new[]
            {
            new[] { 1 },
            new[] { 1, 1 },
            new[] { 1, 2, 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(3));
        }
        [Fact]
        public void Four_rows()
        {
            var expected = new[]
            {
            new[] { 1 },
            new[] { 1, 1 },
            new[] { 1, 2, 1 },
            new[] { 1, 3, 3, 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(4));
        }
        [Fact]
        public void Five_rows()
        {
            var expected = new[]
            {
            new[] { 1 },
            new[] { 1, 1 },
            new[] { 1, 2, 1 },
            new[] { 1, 3, 3, 1 },
            new[] { 1, 4, 6, 4, 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(5));
        }
        [Fact]
        public void Six_rows()
        {
            var expected = new[]
            {
            new[] { 1 },
            new[] { 1, 1 },
            new[] { 1, 2, 1 },
            new[] { 1, 3, 3, 1 },
            new[] { 1, 4, 6, 4, 1 },
            new[] { 1, 5, 10, 10, 5, 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(6));
        }
        [Fact]
        public void Ten_rows()
        {
            var expected = new[]
            {
            new[] { 1 },
            new[] { 1, 1 },
            new[] { 1, 2, 1 },
            new[] { 1, 3, 3, 1 },
            new[] { 1, 4, 6, 4, 1 },
            new[] { 1, 5, 10, 10, 5, 1 },
            new[] { 1, 6, 15, 20, 15, 6, 1 },
            new[] { 1, 7, 21, 35, 35, 21, 7, 1 },
            new[] { 1, 8, 28, 56, 70, 56, 28, 8, 1 },
            new[] { 1, 9, 36, 84, 126, 126, 84, 36, 9, 1 }
        };
            Assert.Equal(expected, PascalsTriangle.Calculate(10));
        }
    }
}