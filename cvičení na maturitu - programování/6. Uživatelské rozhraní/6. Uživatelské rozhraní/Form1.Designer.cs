namespace _6.Uživatelské_rozhraní
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.barvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.červenáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modráToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zelenáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.žlutáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonElipse = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barvaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // barvaToolStripMenuItem
            // 
            this.barvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.červenáToolStripMenuItem,
            this.modráToolStripMenuItem,
            this.zelenáToolStripMenuItem,
            this.žlutáToolStripMenuItem});
            this.barvaToolStripMenuItem.Name = "barvaToolStripMenuItem";
            this.barvaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.barvaToolStripMenuItem.Text = "barva";
            // 
            // červenáToolStripMenuItem
            // 
            this.červenáToolStripMenuItem.Name = "červenáToolStripMenuItem";
            this.červenáToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.červenáToolStripMenuItem.Text = "červená";
            this.červenáToolStripMenuItem.Click += new System.EventHandler(this.červenáToolStripMenuItem_Click);
            // 
            // modráToolStripMenuItem
            // 
            this.modráToolStripMenuItem.Name = "modráToolStripMenuItem";
            this.modráToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modráToolStripMenuItem.Text = "modrá";
            this.modráToolStripMenuItem.Click += new System.EventHandler(this.modráToolStripMenuItem_Click);
            // 
            // zelenáToolStripMenuItem
            // 
            this.zelenáToolStripMenuItem.Name = "zelenáToolStripMenuItem";
            this.zelenáToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zelenáToolStripMenuItem.Text = "zelená";
            this.zelenáToolStripMenuItem.Click += new System.EventHandler(this.zelenáToolStripMenuItem_Click);
            // 
            // žlutáToolStripMenuItem
            // 
            this.žlutáToolStripMenuItem.Name = "žlutáToolStripMenuItem";
            this.žlutáToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.žlutáToolStripMenuItem.Text = "žlutá";
            this.žlutáToolStripMenuItem.Click += new System.EventHandler(this.žlutáToolStripMenuItem_Click);
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new System.Drawing.Point(52, 184);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(51, 17);
            this.checkBoxFill.TabIndex = 1;
            this.checkBoxFill.Text = "výplň";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            this.checkBoxFill.CheckedChanged += new System.EventHandler(this.checkBoxFill_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(52, 118);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRectangle.TabIndex = 2;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Čtverec";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonElipse
            // 
            this.radioButtonElipse.AutoSize = true;
            this.radioButtonElipse.Location = new System.Drawing.Point(52, 150);
            this.radioButtonElipse.Name = "radioButtonElipse";
            this.radioButtonElipse.Size = new System.Drawing.Size(47, 17);
            this.radioButtonElipse.TabIndex = 3;
            this.radioButtonElipse.TabStop = true;
            this.radioButtonElipse.Text = "Kruh";
            this.radioButtonElipse.UseVisualStyleBackColor = true;
            this.radioButtonElipse.CheckedChanged += new System.EventHandler(this.radioButtonElipse_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(200, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 350);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(48, 228);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(82, 42);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Kresli";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButtonElipse);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem barvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem červenáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modráToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zelenáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem žlutáToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonElipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

