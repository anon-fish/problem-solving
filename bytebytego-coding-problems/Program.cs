using Solutions;
using System.Diagnostics;

// Main program to run the Solutions
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
TwoSums.Run();
stopwatch.Stop();
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
