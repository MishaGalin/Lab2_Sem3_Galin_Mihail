using System;
using System.Drawing;

namespace Lab2_Sem3_Galin_Mihail
{
    public class GraphObject
    {
        private Color c;
        private int x, y, w, h;

        private SolidBrush brush;
        private static Random r = new Random();

        public GraphObject()
        {
            Color[] cols = { Color.Red, Color.Green, Color.Yellow, Color.Tomato, Color.Cyan };
            c = cols[r.Next(cols.Length)];
            x = r.Next(200);
            y = r.Next(200);
            w = 50;
            h = 50;
            brush = new SolidBrush(c);
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, x, y, w, h);
            g.DrawRectangle(Pens.Black, x, y, w, h);
        }
    }
}