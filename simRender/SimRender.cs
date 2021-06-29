using System;
using System.Diagnostics;
using System.Threading;

namespace simRender
{
    class SimRender
    {
        static Walker[] walkers = new Walker[100000];

        static Render render;



        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            Console.WriteLine("Spawning agents...");
            for(int i = 0; i < walkers.Length; i++)
            {
                walkers[i] = new Walker();
            }

            Console.WriteLine("Starting render!");
            render = new Render(60, walkers);
            RenderResult result = render.Start();
            result.Export();

            stopwatch.Stop();
            Console.WriteLine("Simulated {0} fotograms with {1} agents in {2} ms", render.length, walkers.Length, stopwatch.ElapsedMilliseconds);
        }
    }
}
