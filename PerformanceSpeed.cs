using System;
using System.Diagnostics;
using System.Threading.Tasks;

class PerformanceSpeed
{
    static void Main(string[] args)
    {
        int numTasks = 1000000;
        int numIterations = 100000;

        Console.WriteLine($"Running {numTasks} tasks with {numIterations} iterations each...");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Parallel.For(0, numTasks, i =>
        {
            for (int j = 0; j < numIterations; j++)
            {
                // Do some work here
            }
        });

        stopwatch.Stop();

        Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        Console.WriteLine($"Average time per task: {(double)stopwatch.ElapsedMilliseconds / numTasks} ms");
        Console.WriteLine($"Average time per iteration: {(double)stopwatch.ElapsedMilliseconds / (numTasks * numIterations)} ms");
    }
}
