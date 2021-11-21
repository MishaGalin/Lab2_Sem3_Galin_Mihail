using System;
using System.Drawing;

namespace Lab2_Sem3_Galin_Mihail
{
    internal class Ellipse : GraphObject
    {
        private float a, b;

        public Ellipse() : base()
        {
            A = 80;
            B = 60;
        }

        public Ellipse(int x, int y) : base(x, y)
        {
            A = 80;
            B = 60;
        }

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }

        public override bool ContainsPoint(Point p)
        {
            float dx = A / 2f, dy = B / 2f;
            return (Math.Pow(x + dx - p.X, 2f) / Math.Pow(dx, 2f) + Math.Pow(y + dy - p.Y, 2) / Math.Pow(dy, 2) <= 1);
        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(brush, X, Y, A, B);
            g.DrawEllipse(Selected ? Pens.Blue : Pens.Black, X, Y, A, B);
        }
    }
}