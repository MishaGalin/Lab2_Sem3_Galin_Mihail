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
            X = r.Next(550);
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

        public int X
        {
            get => x;
            set
            {
                if (value < 0) throw new ArgumentException("x<0!");
                x = value;
            }
        }

        public int Y
        {
            get => y;
            set
            {
                if (value < 0) throw new ArgumentException("y<0!");
                y = value;
            }
        }

        public abstract bool ContainsPoint(Point p);

        public abstract void Draw(Graphics g);
    }
}