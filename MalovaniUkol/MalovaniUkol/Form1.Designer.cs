namespace MalovaniUkol
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
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.buttonLine = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newPageButton = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorBlack = new System.Windows.Forms.Button();
            this.colorYellow = new System.Windows.Forms.Button();
            this.colorCyan = new System.Windows.Forms.Button();
            this.colorOrange = new System.Windows.Forms.Button();
            this.colorPurple = new System.Windows.Forms.Button();
            this.colorRed = new System.Windows.Forms.Button();
            this.colorBlue = new System.Windows.Forms.Button();
            this.colorGreen = new System.Windows.Forms.Button();
            this.colorPink = new System.Windows.Forms.Button();
            this.colorWhite = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.Silver;
            this.optionsPanel.Controls.Add(this.buttonLine);
            this.optionsPanel.Controls.Add(this.button3);
            this.optionsPanel.Controls.Add(this.buttonCircle);
            this.optionsPanel.Controls.Add(this.buttonRectangle);
            this.optionsPanel.Controls.Add(this.buttonEraser);
            this.optionsPanel.Controls.Add(this.buttonPen);
            this.optionsPanel.Controls.Add(this.label2);
            this.optionsPanel.Controls.Add(this.newPageButton);
            this.optionsPanel.Controls.Add(this.hScrollBar1);
            this.optionsPanel.Controls.Add(this.label1);
            this.optionsPanel.Controls.Add(this.colorBlack);
            this.optionsPanel.Controls.Add(this.colorYellow);
            this.optionsPanel.Controls.Add(this.colorCyan);
            this.optionsPanel.Controls.Add(this.colorOrange);
            this.optionsPanel.Controls.Add(this.colorPurple);
            this.optionsPanel.Controls.Add(this.colorRed);
            this.optionsPanel.Controls.Add(this.colorBlue);
            this.optionsPanel.Controls.Add(this.colorGreen);
            this.optionsPanel.Controls.Add(this.colorPink);
            this.optionsPanel.Controls.Add(this.colorWhite);
            this.optionsPanel.Location = new System.Drawing.Point(22, 18);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(1425, 129);
            this.optionsPanel.TabIndex = 0;
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(988, 29);
            this.buttonLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(80, 63);
            this.buttonLine.TabIndex = 21;
            this.buttonLine.Text = "Čára";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1076, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 63);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(812, 29);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(80, 63);
            this.buttonCircle.TabIndex = 18;
            this.buttonCircle.Text = "Kruh";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(900, 29);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(80, 63);
            this.buttonRectangle.TabIndex = 19;
            this.buttonRectangle.Text = "Čtverec";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Location = new System.Drawing.Point(724, 29);
            this.buttonEraser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(80, 63);
            this.buttonEraser.TabIndex = 17;
            this.buttonEraser.Text = "Guma";
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.Location = new System.Drawing.Point(636, 29);
            this.buttonPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(80, 63);
            this.buttonPen.TabIndex = 16;
            this.buttonPen.Text = "Pero";
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tloušťka čáry";
            // 
            // newPageButton
            // 
            this.newPageButton.Location = new System.Drawing.Point(548, 29);
            this.newPageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPageButton.Name = "newPageButton";
            this.newPageButton.Size = new System.Drawing.Size(80, 63);
            this.newPageButton.TabIndex = 15;
            this.newPageButton.Text = "Nový papír";
            this.newPageButton.UseVisualStyleBackColor = true;
            this.newPageButton.Click += new System.EventHandler(this.newPageButton_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(238, 54);
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(287, 25);
            this.hScrollBar1.TabIndex = 13;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "vyber si barvu";
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Location = new System.Drawing.Point(20, 45);
            this.colorBlack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(38, 38);
            this.colorBlack.TabIndex = 2;
            this.colorBlack.UseVisualStyleBackColor = false;
            this.colorBlack.Click += new System.EventHandler(this.colorBlack_Click);
            // 
            // colorYellow
            // 
            this.colorYellow.BackColor = System.Drawing.Color.Yellow;
            this.colorYellow.Location = new System.Drawing.Point(98, 83);
            this.colorYellow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorYellow.Name = "colorYellow";
            this.colorYellow.Size = new System.Drawing.Size(38, 38);
            this.colorYellow.TabIndex = 11;
            this.colorYellow.UseVisualStyleBackColor = false;
            this.colorYellow.Click += new System.EventHandler(this.colorYellow_Click);
            // 
            // colorCyan
            // 
            this.colorCyan.BackColor = System.Drawing.Color.Cyan;
            this.colorCyan.Location = new System.Drawing.Point(58, 45);
            this.colorCyan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorCyan.Name = "colorCyan";
            this.colorCyan.Size = new System.Drawing.Size(38, 38);
            this.colorCyan.TabIndex = 3;
            this.colorCyan.UseVisualStyleBackColor = false;
            this.colorCyan.Click += new System.EventHandler(this.colorCyan_Click);
            // 
            // colorOrange
            // 
            this.colorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorOrange.Location = new System.Drawing.Point(136, 83);
            this.colorOrange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorOrange.Name = "colorOrange";
            this.colorOrange.Size = new System.Drawing.Size(38, 38);
            this.colorOrange.TabIndex = 10;
            this.colorOrange.UseVisualStyleBackColor = false;
            this.colorOrange.Click += new System.EventHandler(this.colorOrange_Click);
            // 
            // colorPurple
            // 
            this.colorPurple.BackColor = System.Drawing.Color.Purple;
            this.colorPurple.Location = new System.Drawing.Point(136, 45);
            this.colorPurple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPurple.Name = "colorPurple";
            this.colorPurple.Size = new System.Drawing.Size(38, 38);
            this.colorPurple.TabIndex = 4;
            this.colorPurple.UseVisualStyleBackColor = false;
            this.colorPurple.Click += new System.EventHandler(this.colorPurple_Click);
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.Red;
            this.colorRed.Location = new System.Drawing.Point(176, 83);
            this.colorRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(38, 38);
            this.colorRed.TabIndex = 9;
            this.colorRed.UseVisualStyleBackColor = false;
            this.colorRed.Click += new System.EventHandler(this.colorRed_Click);
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.Blue;
            this.colorBlue.Location = new System.Drawing.Point(98, 45);
            this.colorBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(38, 38);
            this.colorBlue.TabIndex = 5;
            this.colorBlue.UseVisualStyleBackColor = false;
            this.colorBlue.Click += new System.EventHandler(this.colorBlue_Click);
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.Lime;
            this.colorGreen.Location = new System.Drawing.Point(58, 83);
            this.colorGreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(38, 38);
            this.colorGreen.TabIndex = 8;
            this.colorGreen.UseVisualStyleBackColor = false;
            this.colorGreen.Click += new System.EventHandler(this.colorGreen_Click);
            // 
            // colorPink
            // 
            this.colorPink.BackColor = System.Drawing.Color.Fuchsia;
            this.colorPink.Location = new System.Drawing.Point(176, 45);
            this.colorPink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorPink.Name = "colorPink";
            this.colorPink.Size = new System.Drawing.Size(38, 38);
            this.colorPink.TabIndex = 6;
            this.colorPink.UseVisualStyleBackColor = false;
            this.colorPink.Click += new System.EventHandler(this.colorPink_Click);
            // 
            // colorWhite
            // 
            this.colorWhite.BackColor = System.Drawing.Color.White;
            this.colorWhite.Location = new System.Drawing.Point(20, 83);
            this.colorWhite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorWhite.Name = "colorWhite";
            this.colorWhite.Size = new System.Drawing.Size(38, 38);
            this.colorWhite.TabIndex = 7;
            this.colorWhite.UseVisualStyleBackColor = false;
            this.colorWhite.Click += new System.EventHandler(this.colorWhite_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(22, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1425, 777);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 901);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.optionsPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button colorBlack;
        private System.Windows.Forms.Button colorCyan;
        private System.Windows.Forms.Button colorPurple;
        private System.Windows.Forms.Button colorBlue;
        private System.Windows.Forms.Button colorPink;
        private System.Windows.Forms.Button colorWhite;
        private System.Windows.Forms.Button colorGreen;
        private System.Windows.Forms.Button colorRed;
        private System.Windows.Forms.Button colorOrange;
        private System.Windows.Forms.Button colorYellow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newPageButton;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button button3;
    }
}

