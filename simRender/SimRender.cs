using System;

namespace simRender
{
    class SimRender
    {
        static Walker[] walkers = new Walker[400];

        static Render render;

        static void Main(string[] args)
        {
            Console.WriteLine("Spawning agents...");
            for(int i = 0; i < walkers.Length; i++)
            {
                walkers[i] = new Walker();
            }

            Console.WriteLine("Starting render!");
            render = new Render(60, walkers);
            render.Start();
        }
    }
}
