using System;
using System.Collections.Generic;
using System.Text;

namespace simRender
{
    class RenderSerializer
    {
        public static string Serialize(Walker[,] data)
        {
            string sData = "";
            for (int f = 0; f < data.GetLength(0); f++)
            {
                sData += "<\n";
                for(int i = 0; i < data.GetLength(1); i++)
                {
                    sData += data[f, i].x.ToString() + "\n";
                    sData += data[f, i].y.ToString() + "\n";
                    sData += "+\n";
                }
                Console.WriteLine(f);
            }

            return sData;
        }

    }
}
