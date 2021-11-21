using System;
using System.Drawing;

namespace Lab2_Sem3_Galin_Mihail
{
    public class GraphObject
    {
        private static Random r = new Random();
        private SolidBrush brush;
        private Color c;
        private int x, y, w, h;

        public GraphObject()
        {
            Color[] cols = { Color.Red, Color.Green, Color.Yellow, Color.Tomato, Color.Cyan };
            c = cols[r.Next(cols.Length)];
            X = r.Next(200);
            Y = r.Next(200);
            w = 50;
            h = 50;
            brush = new SolidBrush(c);
        }

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
            g.FillRectangle(Brushes.Red, X, Y, w, h);
            g.DrawRectangle(Pens.Black, X, Y, w, h);
        }
    }
}