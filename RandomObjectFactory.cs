using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Sem3_Galin_Mihail
{
    internal class RandomObjectFactory : IGraphicFactory
    {
        private static readonly Random rand = new Random();

        public GraphObject CreateGraphObject()
        {
            if (rand.Next(2) == 1) return new Ellipse();
            else return new Rectangle();
        }
    }
}