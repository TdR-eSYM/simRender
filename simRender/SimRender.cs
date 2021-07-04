using System;
using System.Diagnostics;
using System.Threading;

namespace simRender
{
    class SimRender
    {
        static Render render;


        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Console.WriteLine("Starting render!");
            render = new Render(30, 1);

            render.Setup();

            RenderResult result = render.Start();

            result.Export();

            stopwatch.Stop();
            Console.WriteLine("Simulated {0} fotograms with {1} agents in {2} ms", render.length, render.walkNum, stopwatch.ElapsedMilliseconds);
        }
    }
}
