using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Sem3_Galin_Mihail
{
    internal class Rectangle : GraphObject
    {
        private int w, h;

        public Rectangle() : base()
        {
            h = 50;
            w = 50;
        }

        public Rectangle(int x, int y) : base(x, y)
        {
            h = 50;
            w = 50;
        }

        public int H { get => h; set => h = value; }
        public int W { get => w; set => w = value; }

        public override bool ContainsPoint(Point p)
        {
            return (p.X <= x + W) & (p.X >= x) & (p.Y >= y) & (p.Y <= y + H);
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(brush, X, Y, W, H);
            g.DrawRectangle(Selected ? Pens.Blue : Pens.Black, X, Y, W, H);
        }
    }
}