using System;
using System.Drawing;

namespace Lab2_Sem3_Galin_Mihail
{
    public abstract class GraphObject
    {
        private static readonly Random r = new Random();
        protected SolidBrush brush;
        protected int x, y;

        public GraphObject()
        {
            Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Tomato, Color.Cyan };
            Selected = false;
            X = r.Next(700);
            Y = r.Next(250);
            brush = new SolidBrush(colors[r.Next(colors.Length)]);
        }

        public GraphObject(int x, int y)
        {
            Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Tomato, Color.Cyan };
            Selected = false;
            X = x;
            Y = y;
            brush = new SolidBrush(colors[r.Next(colors.Length)]);
        }

        public bool Selected { get; set; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public abstract bool ContainsPoint(Point p);

        public abstract void Draw(Graphics g);
    }
}