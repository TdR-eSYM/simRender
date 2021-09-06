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
        private int size;
        private int initialInf;
        private float infChance;
        private RenderResult result;

        public Render(int length, int walkNum, int size, int initialInf, float infChance)
        {
            this.length = length;
            this.walkNum = walkNum;
            this.size = size;
            this.initialInf = initialInf;
            this.infChance = infChance;

            walkers = new Walker[walkNum];
        }

        public void Setup()
        {
            Console.WriteLine("Spawning agents...");
            for(int i = 0; i < walkNum; i++)
            {
                if(initialInf != 0)
                {
                    walkers[i] = new Walker(size, 1);
                    initialInf--;
                }
                else {
                    walkers[i] = new Walker(size, 0);
                }
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
                    walkers[i].Infect(walkNum, walkers, infChance);
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
