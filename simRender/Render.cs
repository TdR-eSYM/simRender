using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace simRender
{
    class Render
    {
        int length;
        Walker[] walkers;
        public Render(int length, Walker[] walkers)
        {
            this.length = length;
            this.walkers = walkers;
        }

        public void Start()
        {
            for (int f = 0; f < length; f++)
            {
                for (int i = 0; i < walkers.Length; i++)
                {
                    walkers[i].Step();
                }

                Console.WriteLine("Rendering {0} / {1}", f+1, length);
            }
            Console.WriteLine("Done!");
        }
    }
}
