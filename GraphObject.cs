using System;
using System.Drawing;

namespace Lab2_Sem3_Galin_Mihail
{
    public class GraphObject
    {
        private static Random r = new Random();
        private SolidBrush brush;
        private int x, y, w, h;

        public GraphObject()
        {
            Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Tomato, Color.Cyan };
            X = r.Next(550);
            Y = r.Next(250);
            w = 50;
            h = 50;
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

        public void Draw(Graphics g)
        {
            g.FillRectangle(brush, X, Y, w, h);
            g.DrawRectangle(Selected ? Pens.Blue : Pens.Black, X, Y, w, h);
        }

        public bool ContainsPoint(Point p)
        {
            return (p.X <= x + w) & (p.X >= x) & (p.Y >= y) & (p.Y <= y + h);
        }
    }
}