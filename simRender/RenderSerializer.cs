using System;
using System.Collections.Generic;
using System.Text;

namespace simRender
{
    class RenderSerializer
    {
        public static byte[] Serialize(float[,,] data)
        {
            float[] bData = new float[(3*data.GetLength(1)) * (1+data.GetLength(0))];
            for (int f = 0; f < data.GetLength(0); f++)
            {
                for(int i = 0; i < data.GetLength(1); i++)
                {
                    bData[f+i] = data[f, i, 0];
                    bData[f+i+1] += data[f, i, 1];
                }
                Console.WriteLine("Exporting {0} / {1}", f + 1, data.GetLength(0));
            }

            var byteArray = new byte[bData.Length * sizeof(float)];
            Buffer.BlockCopy(bData, 0, byteArray, 0, byteArray.Length);

            return byteArray;
        }

    }
}
