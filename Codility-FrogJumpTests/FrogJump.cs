using Codility_FrogJump;

namespace Codility_FrogJumpTests
{
    public class SolutionTests
    {
        private Solution solution = new Solution();

        [Theory]
        [InlineData(10, 85, 30, 3)]
        [InlineData(1, 1, 1, 0)]
        [InlineData(1, 1000000000, 1, 999999999)]
        [InlineData(1, 1, 1000000000, 0)]
        [InlineData(1, 1, 1000000001, -1)] // Invalid input
        [InlineData(10, 5, 3, -1)] // Invalid input
        public void TestSolution(int X, int Y, int D, int expected)
        {
            int result = solution.solution(X, Y, D);
            Assert.Equal(expected, result);
        }
    }
}