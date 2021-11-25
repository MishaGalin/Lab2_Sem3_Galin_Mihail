
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Panel = new MyPanel();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимДобавленияФигурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.MenuStrip.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фигурыToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(804, 24);
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
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.Exit);
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
            this.ToolStrip.Size = new System.Drawing.Size(804, 54);
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
            this.Panel.Size = new System.Drawing.Size(804, 603);
            this.Panel.TabIndex = 4;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintPanel);
            this.Panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDoubleClick);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddFigure);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.ClearFigures);
            // 
            // UpToolStripMenuItem
            // 
            this.UpToolStripMenuItem.Enabled = false;
            this.UpToolStripMenuItem.Name = "UpToolStripMenuItem";
            this.UpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.UpToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.UpToolStripMenuItem.Text = "Вверх";
            this.UpToolStripMenuItem.Click += new System.EventHandler(this.UpToolStripButton_Click);
            // 
            // DownToolStripMenuItem
            // 
            this.DownToolStripMenuItem.Enabled = false;
            this.DownToolStripMenuItem.Name = "DownToolStripMenuItem";
            this.DownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.DownToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DownToolStripMenuItem.Text = "Вниз";
            this.DownToolStripMenuItem.Click += new System.EventHandler(this.DownToolStripButton_Click);
            // 
            // LeftToolStripMenuItem
            // 
            this.LeftToolStripMenuItem.Enabled = false;
            this.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem";
            this.LeftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.LeftToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.LeftToolStripMenuItem.Text = "Влево";
            this.LeftToolStripMenuItem.Click += new System.EventHandler(this.LeftToolStripButton_Click);
            // 
            // RightToolStripMenuItem
            // 
            this.RightToolStripMenuItem.Enabled = false;
            this.RightToolStripMenuItem.Name = "RightToolStripMenuItem";
            this.RightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.RightToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.RightToolStripMenuItem.Text = "Вправо";
            this.RightToolStripMenuItem.Click += new System.EventHandler(this.RightToolStripButton_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.UpToolStripMenuItem,
            this.DownToolStripMenuItem,
            this.LeftToolStripMenuItem,
            this.RightToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.режимДобавленияФигурToolStripMenuItem});
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            // 
            // режимДобавленияФигурToolStripMenuItem
            // 
            this.режимДобавленияФигурToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.режимДобавленияФигурToolStripMenuItem.Name = "режимДобавленияФигурToolStripMenuItem";
            this.режимДобавленияФигурToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.режимДобавленияФигурToolStripMenuItem.Text = "Режим добавления фигур";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownWidth = 150;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Случайные фигуры",
            "Чередующиеся фигуры"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(150, 23);
            this.toolStripComboBox1.Text = "Случайные фигуры";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 681);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ExitButtonWithImage;
        private MyPanel Panel;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton UpToolStripButton;
        private System.Windows.Forms.ToolStripButton DownToolStripButton;
        private System.Windows.Forms.ToolStripButton LeftToolStripButton;
        private System.Windows.Forms.ToolStripButton RightToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимДобавленияФигурToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

