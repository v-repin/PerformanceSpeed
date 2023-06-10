# PerformanceSpeed
Testing of parallelization speed based on your CPU properties

This code uses the `Parallel.For` method to run a large number of tasks in parallel, each with a large number of iterations. The `Stopwatch` class is used to measure the elapsed time, and the results are printed to the console at the end.

You can adjust the `numTasks` and `numIterations` variables to test different scenarios and see how your PC performs. Keep in mind that the actual performance will depend on many factors, including the number of CPU cores, the amount of RAM, and the specific workload being performed.

The test in `PerformanceSpeedTest.cs` creates 100 tasks, each of which performs 1 million iterations of a simple addition operation. The results of each task are stored in an array, and the test asserts that the sum of all the results is equal to the expected value. It also asserts that the total time taken to complete all the tasks is less than 1 second.
