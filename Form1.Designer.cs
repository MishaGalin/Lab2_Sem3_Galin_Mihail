
namespace Lab2_Sem3_Galin_Mihail
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExitButtonWithImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.UpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DownToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Panel = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фигурыToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 22);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            this.фигурыToolStripMenuItem.Click += new System.EventHandler(this.AddFigure);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddFigure);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.ClearFigures);
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButtonWithImage,
            this.toolStripSeparator1,
            this.AddButton,
            this.toolStripButton1,
            this.UpToolStripButton,
            this.DownToolStripButton,
            this.LeftToolStripButton,
            this.RightToolStripButton,
            this.DeleteToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 54);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ExitButtonWithImage
            // 
            this.ExitButtonWithImage.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.icons8_выключение_системы_48;
            this.ExitButtonWithImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitButtonWithImage.Name = "ExitButtonWithImage";
            this.ExitButtonWithImage.Size = new System.Drawing.Size(46, 51);
            this.ExitButtonWithImage.Text = "Выход";
            this.ExitButtonWithImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitButtonWithImage.Click += new System.EventHandler(this.Exit);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // AddButton
            // 
            this.AddButton.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.add1__8284;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 51);
            this.AddButton.Text = "Добавить";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddButton.Click += new System.EventHandler(this.AddFigure);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.cancel__red_4712;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 51);
            this.toolStripButton1.Text = "Очистить";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.ClearFigures);
            // 
            // UpToolStripButton
            // 
            this.UpToolStripButton.Enabled = false;
            this.UpToolStripButton.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.arrow_up_157361;
            this.UpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpToolStripButton.Name = "UpToolStripButton";
            this.UpToolStripButton.Size = new System.Drawing.Size(43, 51);
            this.UpToolStripButton.Text = "Вверх";
            this.UpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UpToolStripButton.Click += new System.EventHandler(this.UpToolStripButton_Click);
            // 
            // DownToolStripButton
            // 
            this.DownToolStripButton.Enabled = false;
            this.DownToolStripButton.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.arrow_down_15736;
            this.DownToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownToolStripButton.Name = "DownToolStripButton";
            this.DownToolStripButton.Size = new System.Drawing.Size(37, 51);
            this.DownToolStripButton.Text = "Вниз";
            this.DownToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DownToolStripButton.Click += new System.EventHandler(this.DownToolStripButton_Click);
            // 
            // LeftToolStripButton
            // 
            this.LeftToolStripButton.Enabled = false;
            this.LeftToolStripButton.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.back_icon_icons_com_74430;
            this.LeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftToolStripButton.Name = "LeftToolStripButton";
            this.LeftToolStripButton.Size = new System.Drawing.Size(44, 51);
            this.LeftToolStripButton.Text = "Влево";
            this.LeftToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LeftToolStripButton.Click += new System.EventHandler(this.LeftToolStripButton_Click);
            // 
            // RightToolStripButton
            // 
            this.RightToolStripButton.Enabled = false;
            this.RightToolStripButton.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.next_icon_icons_com_74443;
            this.RightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightToolStripButton.Name = "RightToolStripButton";
            this.RightToolStripButton.Size = new System.Drawing.Size(51, 51);
            this.RightToolStripButton.Text = "Вправо";
            this.RightToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RightToolStripButton.Click += new System.EventHandler(this.RightToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Enabled = false;
            this.DeleteToolStripButton.Image = global::Lab2_Sem3_Galin_Mihail.Properties.Resources.trash_can_115312;
            this.DeleteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(55, 51);
            this.DeleteToolStripButton.Text = "Удалить";
            this.DeleteToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 78);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(800, 350);
            this.Panel.TabIndex = 4;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel);
            this.Panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDoubleClick);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "ООП - Фигуры";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ExitButtonWithImage;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton UpToolStripButton;
        private System.Windows.Forms.ToolStripButton DownToolStripButton;
        private System.Windows.Forms.ToolStripButton LeftToolStripButton;
        private System.Windows.Forms.ToolStripButton RightToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
    }
}

