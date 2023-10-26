using System.Runtime.CompilerServices;

namespace Codility_FrogJump
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 1;
        private const int RANGE_HIGHEST_VALUE = 1000000000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int X, int Y, int D)
        {
            if (X >= RANGE_LOWEST_VALUE && X <= RANGE_HIGHEST_VALUE &&
                Y >= RANGE_LOWEST_VALUE && Y <= RANGE_HIGHEST_VALUE &&
                D >= RANGE_LOWEST_VALUE && D <= RANGE_HIGHEST_VALUE &&
                X <= Y) 
            {
                // Calculate the distance to cover
                int distanceToCover = Y - X;

                // Calculate the minimal number of jumps needed
                int minimalJumps = distanceToCover / D;

                // If there is a remainder, we need an extra jump
                if (distanceToCover % D != 0)
                    minimalJumps++;

                return minimalJumps;
            }
            return -1; // if the initial conditions are not met regarding the range values and X<=Y then return -1
        }
    }
}
