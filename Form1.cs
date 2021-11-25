using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2_Sem3_Galin_Mihail
{
    public partial class Form1 : Form
    {
        private readonly List<GraphObject> Elements = new List<GraphObject>();
        private readonly List<GraphObject> SelectedElements = new List<GraphObject>();
        private readonly Random rand = new Random();

        private IGraphicFactory factory = new RandomObjectFactory();

        public Form1()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e) => Close();

        private void PaintPanel(object sender, PaintEventArgs e)
        {
            foreach (GraphObject elem in Elements) { elem.Draw(e.Graphics); }
        }

        private void AddFigure(object sender, EventArgs e)
        {
            Elements.Add(factory.CreateGraphObject());
            Refresh();
        }

        private void ClearFigures(object sender, EventArgs e)
        {
            Elements.Clear();
            Refresh();
        }

        private void Panel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rand.Next(2) == 1)
            {
                Ellipse ellipse = new Ellipse(e.X, e.Y);
                ellipse.X = (int)(ellipse.X - ellipse.A / 2);
                ellipse.Y = (int)(ellipse.Y - ellipse.B / 2);
                Elements.Add(ellipse);
            }
            else
            {
                Rectangle rectangle = new Rectangle(e.X, e.Y);
                rectangle.X -= rectangle.W / 2;
                rectangle.Y -= rectangle.H / 2;
                Elements.Add(rectangle);
            }
            Refresh();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].ContainsPoint(e.Location))
                {
                    if (!(Control.ModifierKeys == Keys.Control))
                    {
                        foreach (GraphObject elem in SelectedElements)
                        {
                            elem.Selected = false;
                        }
                        SelectedElements.Clear();
                    }
                    Elements[i].Selected = true;
                    SelectedElements.Add(Elements[i]);
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
                    Refresh();
                    return;
                }
            }

            if (!(Control.ModifierKeys == Keys.Control))
            {
                foreach (GraphObject elem in SelectedElements)
                {
                    elem.Selected = false;
                }
                SelectedElements.Clear();
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
            }
            Refresh();
        }

        private void UpToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (GraphObject elem in SelectedElements) { elem.Y -= 5; }
            Refresh();
        }

        private void DownToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (GraphObject elem in SelectedElements) { elem.Y += 5; }
            Refresh();
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (GraphObject elem in SelectedElements) { elem.X -= 5; }
            Refresh();
        }

        private void RightToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (GraphObject elem in SelectedElements) { elem.X += 5; }
            Refresh();
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (GraphObject elem in SelectedElements)
            {
                Elements.Remove(elem);
            }

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