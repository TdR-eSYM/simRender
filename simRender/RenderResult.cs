using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace simRender
{
    class RenderResult
    {
        float[,,] data;
        Render render;

        public RenderResult(Render render)
        {
            this.render = render;
            data = new float[render.length, render.walkNum, 2];
        }

        public void PushData(int f, Walker[] inData)
        {
            for(int i = 0; i < render.walkNum; i++)
            {
                data[f, i, 0] = inData[i].x;
                data[f, i, 1] = inData[i].y;
            }
            Console.WriteLine("Frame {0}", data[f, 0, 0]);
        }

        public void Export()
        {
            byte[] bData = RenderSerializer.Serialize(data);

            string fileName = "export.sim";
            File.WriteAllBytes(fileName, bData);
        }
    }
}
