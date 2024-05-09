namespace _2._5.Pole_ve_formulářích
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
            this.textBoxVstup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVysledek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxVstup
            // 
            this.textBoxVstup.Location = new System.Drawing.Point(146, 40);
            this.textBoxVstup.Name = "textBoxVstup";
            this.textBoxVstup.Size = new System.Drawing.Size(231, 20);
            this.textBoxVstup.TabIndex = 0;
            this.textBoxVstup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxVstup_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "zadej max 10 čísel";
            // 
            // textBoxPole
            // 
            this.textBoxPole.Location = new System.Drawing.Point(31, 127);
            this.textBoxPole.Name = "textBoxPole";
            this.textBoxPole.Size = new System.Drawing.Size(230, 20);
            this.textBoxPole.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "moje čísla";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zjisti počet výskytu minima";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxVysledek
            // 
            this.textBoxVysledek.Location = new System.Drawing.Point(438, 236);
            this.textBoxVysledek.Multiline = true;
            this.textBoxVysledek.Name = "textBoxVysledek";
            this.textBoxVysledek.Size = new System.Drawing.Size(207, 50);
            this.textBoxVysledek.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxVysledek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVstup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVstup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVysledek;
    }
}

