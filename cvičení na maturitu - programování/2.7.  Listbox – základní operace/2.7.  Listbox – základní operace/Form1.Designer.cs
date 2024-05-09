namespace _2._7.Listbox___základní_operace
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddToEnd = new System.Windows.Forms.Button();
            this.buttonAddToStart = new System.Windows.Forms.Button();
            this.buttonAddToIndex = new System.Windows.Forms.Button();
            this.buttonDelLast = new System.Windows.Forms.Button();
            this.buttonDelFirst = new System.Windows.Forms.Button();
            this.buttonDelIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadej jméno:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(68, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 225);
            this.listBox1.TabIndex = 2;
            // 
            // buttonAddToEnd
            // 
            this.buttonAddToEnd.Location = new System.Drawing.Point(353, 175);
            this.buttonAddToEnd.Name = "buttonAddToEnd";
            this.buttonAddToEnd.Size = new System.Drawing.Size(141, 56);
            this.buttonAddToEnd.TabIndex = 3;
            this.buttonAddToEnd.Text = "Přidej na konec";
            this.buttonAddToEnd.UseVisualStyleBackColor = true;
            this.buttonAddToEnd.Click += new System.EventHandler(this.buttonAddToEnd_Click);
            // 
            // buttonAddToStart
            // 
            this.buttonAddToStart.Location = new System.Drawing.Point(353, 100);
            this.buttonAddToStart.Name = "buttonAddToStart";
            this.buttonAddToStart.Size = new System.Drawing.Size(141, 56);
            this.buttonAddToStart.TabIndex = 4;
            this.buttonAddToStart.Text = "Přidej na začátek";
            this.buttonAddToStart.UseVisualStyleBackColor = true;
            this.buttonAddToStart.Click += new System.EventHandler(this.buttonAddToStart_Click);
            // 
            // buttonAddToIndex
            // 
            this.buttonAddToIndex.Location = new System.Drawing.Point(353, 250);
            this.buttonAddToIndex.Name = "buttonAddToIndex";
            this.buttonAddToIndex.Size = new System.Drawing.Size(141, 56);
            this.buttonAddToIndex.TabIndex = 6;
            this.buttonAddToIndex.Text = "Přidej na označenou pozici";
            this.buttonAddToIndex.UseVisualStyleBackColor = true;
            this.buttonAddToIndex.Click += new System.EventHandler(this.buttonAddToIndex_Click);
            // 
            // buttonDelLast
            // 
            this.buttonDelLast.Location = new System.Drawing.Point(525, 175);
            this.buttonDelLast.Name = "buttonDelLast";
            this.buttonDelLast.Size = new System.Drawing.Size(141, 56);
            this.buttonDelLast.TabIndex = 5;
            this.buttonDelLast.Text = "Smaž poslední";
            this.buttonDelLast.UseVisualStyleBackColor = true;
            this.buttonDelLast.Click += new System.EventHandler(this.buttonDelLast_Click);
            // 
            // buttonDelFirst
            // 
            this.buttonDelFirst.Location = new System.Drawing.Point(525, 100);
            this.buttonDelFirst.Name = "buttonDelFirst";
            this.buttonDelFirst.Size = new System.Drawing.Size(141, 56);
            this.buttonDelFirst.TabIndex = 8;
            this.buttonDelFirst.Text = "Smaž první";
            this.buttonDelFirst.UseVisualStyleBackColor = true;
            this.buttonDelFirst.Click += new System.EventHandler(this.buttonDelFirst_Click);
            // 
            // buttonDelIndex
            // 
            this.buttonDelIndex.Location = new System.Drawing.Point(525, 250);
            this.buttonDelIndex.Name = "buttonDelIndex";
            this.buttonDelIndex.Size = new System.Drawing.Size(141, 56);
            this.buttonDelIndex.TabIndex = 7;
            this.buttonDelIndex.Text = "Smaž ozančený";
            this.buttonDelIndex.UseVisualStyleBackColor = true;
            this.buttonDelIndex.Click += new System.EventHandler(this.buttonDelIndex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelFirst);
            this.Controls.Add(this.buttonDelIndex);
            this.Controls.Add(this.buttonAddToIndex);
            this.Controls.Add(this.buttonDelLast);
            this.Controls.Add(this.buttonAddToStart);
            this.Controls.Add(this.buttonAddToEnd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddToEnd;
        private System.Windows.Forms.Button buttonAddToStart;
        private System.Windows.Forms.Button buttonAddToIndex;
        private System.Windows.Forms.Button buttonDelLast;
        private System.Windows.Forms.Button buttonDelFirst;
        private System.Windows.Forms.Button buttonDelIndex;
    }
}

