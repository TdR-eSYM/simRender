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
        }

        public void Export()
        {
            data = new Walker[render.length, render.walkers.Length];
            string json = JsonSerializer.Serialize(data);

            string fileName = "export.json";
            File.WriteAllText(fileName, json);
        }
    }
}
