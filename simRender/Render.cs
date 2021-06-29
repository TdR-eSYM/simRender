using System;
using System.Collections.Generic;

namespace simRender
{
    class Render
    {
        public int length;
        public Walker[] walkers;
        private RenderResult result;

        public Render(int length, Walker[] walkers)
        {
            this.length = length;
            this.walkers = walkers;
        }

        public void Start()
        {
            result = new RenderResult(this);

            for (int f = 0; f < length; f++)
            {
                for (int i = 0; i < walkers.Length; i++)
                {
                    walkers[i].Step();
                }

                Console.WriteLine("Rendering {0} / {1}", f+1, length);
            }
            Console.WriteLine("Done!");
            result.Export();
        }
    }
}
