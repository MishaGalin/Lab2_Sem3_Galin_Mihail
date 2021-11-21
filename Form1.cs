using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2_Sem3_Galin_Mihail
{
    public partial class Form1 : Form
    {
        private List<GraphObject> elements = new List<GraphObject>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            foreach (GraphObject elem in elements) { elem.Draw(e.Graphics); }
        }

        private void AddFigure(object sender, EventArgs e)
        {
            elements.Add(new GraphObject());
            Refresh();
        }

        private void ClearFigures(object sender, EventArgs e)
        {
        }

        private void Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GraphObject figure = new GraphObject
            {
                X = e.X,
                Y = e.Y
            };
            elements.Add(figure);
            Refresh();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].Selected = false;
                if (elements[i].ContainsPoint(e.Location))
                {
                    elements[i].Selected = true;
                }
            }
            Refresh();
        }
    }
}