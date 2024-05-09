namespace _3._1.Práce_se_znakem_a_řetězci2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonToCz = new System.Windows.Forms.Button();
            this.buttonToMors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 221);
            this.textBox2.TabIndex = 1;
            // 
            // buttonToCz
            // 
            this.buttonToCz.Location = new System.Drawing.Point(42, 51);
            this.buttonToCz.Name = "buttonToCz";
            this.buttonToCz.Size = new System.Drawing.Size(118, 38);
            this.buttonToCz.TabIndex = 2;
            this.buttonToCz.Text = "Přelož do češtiny";
            this.buttonToCz.UseVisualStyleBackColor = true;
            this.buttonToCz.Click += new System.EventHandler(this.buttonToCz_Click);
            // 
            // buttonToMors
            // 
            this.buttonToMors.Location = new System.Drawing.Point(181, 51);
            this.buttonToMors.Name = "buttonToMors";
            this.buttonToMors.Size = new System.Drawing.Size(118, 38);
            this.buttonToMors.TabIndex = 3;
            this.buttonToMors.Text = "Přelož do morseovky";
            this.buttonToMors.UseVisualStyleBackColor = true;
            this.buttonToMors.Click += new System.EventHandler(this.buttonToMors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 357);
            this.Controls.Add(this.buttonToMors);
            this.Controls.Add(this.buttonToCz);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonToCz;
        private System.Windows.Forms.Button buttonToMors;
    }
}

