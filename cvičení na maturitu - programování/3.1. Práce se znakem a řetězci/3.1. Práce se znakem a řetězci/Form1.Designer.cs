namespace _3._1.Práce_se_znakem_a_řetězci
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
            this.buttonToUpper = new System.Windows.Forms.Button();
            this.buttonDelGap = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonAddToIndex = new System.Windows.Forms.Button();
            this.buttonDelAtIndex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZnak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPozice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVysledek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxVstup
            // 
            this.textBoxVstup.Location = new System.Drawing.Point(222, 34);
            this.textBoxVstup.Name = "textBoxVstup";
            this.textBoxVstup.Size = new System.Drawing.Size(242, 20);
            this.textBoxVstup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadaný řetězec:";
            // 
            // buttonToUpper
            // 
            this.buttonToUpper.Location = new System.Drawing.Point(24, 75);
            this.buttonToUpper.Name = "buttonToUpper";
            this.buttonToUpper.Size = new System.Drawing.Size(125, 42);
            this.buttonToUpper.TabIndex = 2;
            this.buttonToUpper.Text = "Převeď na velká písmena";
            this.buttonToUpper.UseVisualStyleBackColor = true;
            this.buttonToUpper.Click += new System.EventHandler(this.buttonToUpper_Click);
            // 
            // buttonDelGap
            // 
            this.buttonDelGap.Location = new System.Drawing.Point(175, 75);
            this.buttonDelGap.Name = "buttonDelGap";
            this.buttonDelGap.Size = new System.Drawing.Size(125, 42);
            this.buttonDelGap.TabIndex = 3;
            this.buttonDelGap.Text = "Odstraň mezery";
            this.buttonDelGap.UseVisualStyleBackColor = true;
            this.buttonDelGap.Click += new System.EventHandler(this.buttonDelGap_Click);
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(330, 75);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(125, 42);
            this.buttonSplit.TabIndex = 4;
            this.buttonSplit.Text = "Rozděl řetězec podle mezer";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // buttonAddToIndex
            // 
            this.buttonAddToIndex.Location = new System.Drawing.Point(222, 154);
            this.buttonAddToIndex.Name = "buttonAddToIndex";
            this.buttonAddToIndex.Size = new System.Drawing.Size(125, 42);
            this.buttonAddToIndex.TabIndex = 5;
            this.buttonAddToIndex.Text = "Vlož znak na pozici";
            this.buttonAddToIndex.UseVisualStyleBackColor = true;
            this.buttonAddToIndex.Click += new System.EventHandler(this.buttonAddToIndex_Click);
            // 
            // buttonDelAtIndex
            // 
            this.buttonDelAtIndex.Location = new System.Drawing.Point(222, 209);
            this.buttonDelAtIndex.Name = "buttonDelAtIndex";
            this.buttonDelAtIndex.Size = new System.Drawing.Size(125, 42);
            this.buttonDelAtIndex.TabIndex = 6;
            this.buttonDelAtIndex.Text = "Zruš znak na pozici";
            this.buttonDelAtIndex.UseVisualStyleBackColor = true;
            this.buttonDelAtIndex.Click += new System.EventHandler(this.buttonDelAtIndex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "znak:";
            // 
            // textBoxZnak
            // 
            this.textBoxZnak.Location = new System.Drawing.Point(107, 180);
            this.textBoxZnak.Name = "textBoxZnak";
            this.textBoxZnak.Size = new System.Drawing.Size(95, 20);
            this.textBoxZnak.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "pozice:";
            // 
            // textBoxPozice
            // 
            this.textBoxPozice.Location = new System.Drawing.Point(117, 206);
            this.textBoxPozice.Name = "textBoxPozice";
            this.textBoxPozice.Size = new System.Drawing.Size(85, 20);
            this.textBoxPozice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Výsledek:";
            // 
            // textBoxVysledek
            // 
            this.textBoxVysledek.Location = new System.Drawing.Point(470, 123);
            this.textBoxVysledek.Multiline = true;
            this.textBoxVysledek.Name = "textBoxVysledek";
            this.textBoxVysledek.Size = new System.Drawing.Size(242, 197);
            this.textBoxVysledek.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVysledek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPozice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxZnak);
            this.Controls.Add(this.buttonDelAtIndex);
            this.Controls.Add(this.buttonAddToIndex);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.buttonDelGap);
            this.Controls.Add(this.buttonToUpper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVstup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVstup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToUpper;
        private System.Windows.Forms.Button buttonDelGap;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Button buttonAddToIndex;
        private System.Windows.Forms.Button buttonDelAtIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZnak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPozice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVysledek;
    }
}

