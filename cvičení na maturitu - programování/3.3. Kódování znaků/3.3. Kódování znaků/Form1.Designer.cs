namespace _3._3.Kódování_znaků
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
            this.buttonWriteAll = new System.Windows.Forms.Button();
            this.buttonWriteRnd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonWriteAll
            // 
            this.buttonWriteAll.Location = new System.Drawing.Point(200, 25);
            this.buttonWriteAll.Name = "buttonWriteAll";
            this.buttonWriteAll.Size = new System.Drawing.Size(200, 55);
            this.buttonWriteAll.TabIndex = 0;
            this.buttonWriteAll.Text = "Vypiš všechna velká písmena";
            this.buttonWriteAll.UseVisualStyleBackColor = true;
            this.buttonWriteAll.Click += new System.EventHandler(this.buttonWriteAll_Click);
            // 
            // buttonWriteRnd
            // 
            this.buttonWriteRnd.Location = new System.Drawing.Point(200, 99);
            this.buttonWriteRnd.Name = "buttonWriteRnd";
            this.buttonWriteRnd.Size = new System.Drawing.Size(200, 55);
            this.buttonWriteRnd.TabIndex = 1;
            this.buttonWriteRnd.Text = "Vypiš náhodná velká písmena";
            this.buttonWriteRnd.UseVisualStyleBackColor = true;
            this.buttonWriteRnd.Click += new System.EventHandler(this.buttonWriteRnd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 184);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 239);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonWriteRnd);
            this.Controls.Add(this.buttonWriteAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWriteAll;
        private System.Windows.Forms.Button buttonWriteRnd;
        private System.Windows.Forms.TextBox textBox1;
    }
}

