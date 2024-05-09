namespace _3._2.Práce_s_textovým_souborem
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
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonPrintFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVstup = new System.Windows.Forms.TextBox();
            this.listBoxVystup = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(215, 94);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(102, 48);
            this.buttonSaveToFile.TabIndex = 0;
            this.buttonSaveToFile.Text = "Zapiš jména do souboru";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonPrintFile
            // 
            this.buttonPrintFile.Location = new System.Drawing.Point(361, 94);
            this.buttonPrintFile.Name = "buttonPrintFile";
            this.buttonPrintFile.Size = new System.Drawing.Size(102, 48);
            this.buttonPrintFile.TabIndex = 1;
            this.buttonPrintFile.Text = "Vypiš soubor";
            this.buttonPrintFile.UseVisualStyleBackColor = true;
            this.buttonPrintFile.Click += new System.EventHandler(this.buttonPrintFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "jméno:";
            // 
            // textBoxVstup
            // 
            this.textBoxVstup.Location = new System.Drawing.Point(256, 59);
            this.textBoxVstup.Name = "textBoxVstup";
            this.textBoxVstup.Size = new System.Drawing.Size(207, 20);
            this.textBoxVstup.TabIndex = 3;
            // 
            // listBoxVystup
            // 
            this.listBoxVystup.FormattingEnabled = true;
            this.listBoxVystup.Location = new System.Drawing.Point(215, 161);
            this.listBoxVystup.Name = "listBoxVystup";
            this.listBoxVystup.Size = new System.Drawing.Size(248, 147);
            this.listBoxVystup.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxVystup);
            this.Controls.Add(this.textBoxVstup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrintFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonPrintFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVstup;
        private System.Windows.Forms.ListBox listBoxVystup;
    }
}

