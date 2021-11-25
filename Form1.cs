using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2_Sem3_Galin_Mihail
{
    public partial class Form1 : Form
    {
        private int SelectedNumber = -1;
        private readonly List<GraphObject> elements = new List<GraphObject>();
        private readonly Random rand = new Random();
        private IGraphicFactory factory = new RandomObjectFactory();

        public Form1()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e) => Close();

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            foreach (GraphObject elem in elements) { elem.Draw(e.Graphics); }
        }

        private void AddFigure(object sender, EventArgs e)
        {
            elements.Add(factory.CreateGraphObject());
            Refresh();
        }

        private void ClearFigures(object sender, EventArgs e)
        {
            elements.Clear();
            Refresh();
        }

        private void Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rand.Next(2) == 1)
            {
                Ellipse ellipse = new Ellipse(e.X, e.Y);
                ellipse.X = (int)(ellipse.X - ellipse.A / 2);
                ellipse.Y = (int)(ellipse.Y - ellipse.B / 2);
                elements.Add(ellipse);
            }
            else
            {
                Rectangle rectangle = new Rectangle(e.X, e.Y);
                rectangle.X -= rectangle.W / 2;
                rectangle.Y -= rectangle.H / 2;
                elements.Add(rectangle);
            }
            Refresh();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            UpToolStripButton.Enabled = false;
            DownToolStripButton.Enabled = false;
            LeftToolStripButton.Enabled = false;
            RightToolStripButton.Enabled = false;
            DeleteToolStripButton.Enabled = false;
            UpToolStripMenuItem.Enabled = false;
            DownToolStripMenuItem.Enabled = false;
            LeftToolStripMenuItem.Enabled = false;
            RightToolStripMenuItem.Enabled = false;
            DeleteToolStripMenuItem.Enabled = false;

            SelectedNumber = -1;

            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].Selected = false;
                if (elements[i].ContainsPoint(e.Location))
                {
                    UpToolStripButton.Enabled = true;
                    DownToolStripButton.Enabled = true;
                    LeftToolStripButton.Enabled = true;
                    RightToolStripButton.Enabled = true;
                    DeleteToolStripButton.Enabled = true;
                    UpToolStripMenuItem.Enabled = true;
                    DownToolStripMenuItem.Enabled = true;
                    LeftToolStripMenuItem.Enabled = true;
                    RightToolStripMenuItem.Enabled = true;
                    DeleteToolStripMenuItem.Enabled = true;

                    SelectedNumber = i;
                    elements[i].Selected = true;
                }
            }
            Refresh();
        }

        private void UpToolStripButton_Click(object sender, EventArgs e)
        {
            elements[SelectedNumber].Y -= 5;
            Refresh();
        }

        private void DownToolStripButton_Click(object sender, EventArgs e)
        {
            elements[SelectedNumber].Y += 5;
            Refresh();
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e)
        {
            elements[SelectedNumber].X -= 5;
            Refresh();
        }

        private void RightToolStripButton_Click(object sender, EventArgs e)
        {
            elements[SelectedNumber].X += 5;
            Refresh();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            elements.Remove(elements[SelectedNumber]);
            SelectedNumber = -1;
            UpToolStripButton.Enabled = false;
            DownToolStripButton.Enabled = false;
            LeftToolStripButton.Enabled = false;
            RightToolStripButton.Enabled = false;
            DeleteToolStripButton.Enabled = false;

            Refresh();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "Случайные фигуры") factory = new RandomObjectFactory();
            else factory = new TwoTypeFactory();
        }
    }
}