using System;
using System.Collections.Generic;
using System.IO;

namespace simRender
{
    class Render
    {
        public int length;
        public int walkNum;
        public Walker[] walkers;
        private RenderResult result;

        public Render(int length, int walkNum)
        {
            this.length = length;
            this.walkNum = walkNum;
            walkers = new Walker[walkNum];
        }

        public void Setup()
        {
            Console.WriteLine("Spawning agents...");
            for(int i = 0; i < walkNum; i++)
            {
                walkers[i] = new Walker();
            }
        }

        public RenderResult Start()
        {
            result = new RenderResult(this);

            for (int f = 0; f < length; f++)
            {
                for(int i = 0; i < walkNum; i++)
                {
                    walkers[i].Step();
                }
                result.PushData(f, walkers);
#if DEBUG
                Console.WriteLine("Rendering {0} / {1}", f, length);
#endif
            }

            return result;
        }
    }
}
