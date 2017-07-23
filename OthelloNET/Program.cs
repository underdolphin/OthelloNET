using System.Collections.Generic;
using asd;
using static asd.Engine;
using static OthelloNET.MetaInfo;

namespace OthelloNET
{
    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        internal static void Main()
        {
            Initialize(ProgramName, 640, 480, new EngineOption());
            var backObjects = new List<GeometryObject2D>();

            for (int x = 1; x < 9; x++)
            {
                for (int y = 1; y < 9; y++)
                {
                    var backObject = new GeometryObject2D();
                    var rect = new RectangleShape();
                    var xPos = x * 60 - 60 + 80;
                    var yPos = y * 60 - 60;
                    rect.DrawingArea = new RectF(xPos, yPos, 60, 60);
                    var cpWidth = y * 60 - 30;
                    var cpHeight = y * 60 - 30;
                    rect.CenterPosition = new Vector2DF(cpWidth, cpHeight);
                    backObject.Shape = rect;
                    backObject.Color = new Color(30, 30, 30, 255);
                    backObjects.Add(backObject);
                }
            }

            foreach (var backObject in backObjects)
            {
                AddObject2D(backObject);
            }

            var greenObjects = new List<GeometryObject2D>();

            for (int x = 1; x < 9; x++)
            {
                for (int y = 1; y < 9; y++)
                {
                    var greenObject = new GeometryObject2D();
                    var rect = new RectangleShape();
                    var xPos = x * 60 - 60 + 80 + 2;
                    var yPos = y * 60 - 60;
                    rect.DrawingArea = new RectF(xPos, yPos, 55, 55);
                    var cpWidth = y * 60 - 30;
                    var cpHeight = y * 60 - 30;
                    rect.CenterPosition = new Vector2DF(cpWidth, cpHeight);
                    greenObject.Shape = rect;
                    greenObject.Color = new Color(0, 200, 0, 255);

                    greenObjects.Add(greenObject);
                }
            }

            foreach (var greenObject in greenObjects)
            {
                AddObject2D(greenObject);
            }

            while (DoEvents())
            {
                Update();
            }

            Terminate();
        }
    }
}
