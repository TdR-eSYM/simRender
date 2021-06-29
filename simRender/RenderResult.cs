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
        Walker[,] data;
        Render render;

        public RenderResult(Render render)
        {
            this.render = render;
            data = new Walker[render.length, render.walkers.Length];
        }

        public void PushData(int frame, Walker[] frameData)
        {
            for(int i = 0; i < frameData.Length; i++){
                data[frame, i] = frameData[i];
            }
        }

        public void Export()
        {
            string json = RenderSerializer.Serialize(data);

            string fileName = "export.sim";
            File.WriteAllText(fileName, json);
        }
    }
}
