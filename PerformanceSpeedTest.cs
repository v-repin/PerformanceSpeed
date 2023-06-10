using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace ParallelizationDemo.Tests
{
    public class ParallelizationTests
    {
        [Fact]
        public void TestParallelizationEfficiency()
        {
            // Arrange
            int numTasks = 100;
            int numIterations = 1000000;
            int[] results = new int[numTasks];

            // Act
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.For(0, numTasks, i =>
            {
                int result = 0;
                for (int j = 0; j < numIterations; j++)
                {
                    result += j;
                }
                results[i] = result;
            });

            stopwatch.Stop();

            // Assert
            Assert.Equal(numTasks * numIterations, results.Sum());
            Assert.True(stopwatch.ElapsedMilliseconds < 1000);
        }
    }
}