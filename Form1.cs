﻿using System;
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
            foreach (GraphObject elem in elements)
            {
                elem.Draw(e.Graphics);
            }
        }

        private void AddFigure(object sender, EventArgs e)
        {
            GraphObject figure = new GraphObject();
            elements.Add(figure);
            Panel.Invalidate();
        }

        private void ClearFigures(object sender, EventArgs e)
        {
        }
    }
}