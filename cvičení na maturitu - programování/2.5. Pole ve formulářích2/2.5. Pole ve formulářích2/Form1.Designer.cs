namespace _2._5.Pole_ve_formulářích2
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
            this.textBoxPole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVysledek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPole
            // 
            this.textBoxPole.Location = new System.Drawing.Point(217, 42);
            this.textBoxPole.Name = "textBoxPole";
            this.textBoxPole.Size = new System.Drawing.Size(242, 20);
            this.textBoxPole.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "vygenerovaná čísla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Průměr čísel a počet čísel větších než průměr";
            // 
            // textBoxVysledek
            // 
            this.textBoxVysledek.Location = new System.Drawing.Point(217, 136);
            this.textBoxVysledek.Multiline = true;
            this.textBoxVysledek.Name = "textBoxVysledek";
            this.textBoxVysledek.Size = new System.Drawing.Size(242, 50);
            this.textBoxVysledek.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxVysledek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVysledek;
    }
}

