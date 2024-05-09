namespace _2._6.List___základní_operace
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
            this.buttonToEnd = new System.Windows.Forms.Button();
            this.buttonToStart = new System.Windows.Forms.Button();
            this.buttonDelLast = new System.Windows.Forms.Button();
            this.buttonDelFirst = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxVstup
            // 
            this.textBoxVstup.Location = new System.Drawing.Point(221, 35);
            this.textBoxVstup.Name = "textBoxVstup";
            this.textBoxVstup.Size = new System.Drawing.Size(197, 20);
            this.textBoxVstup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "jméno:";
            // 
            // buttonToEnd
            // 
            this.buttonToEnd.Location = new System.Drawing.Point(180, 88);
            this.buttonToEnd.Name = "buttonToEnd";
            this.buttonToEnd.Size = new System.Drawing.Size(106, 42);
            this.buttonToEnd.TabIndex = 2;
            this.buttonToEnd.Text = "Vlož na konec";
            this.buttonToEnd.UseVisualStyleBackColor = true;
            this.buttonToEnd.Click += new System.EventHandler(this.buttonToEnd_Click);
            // 
            // buttonToStart
            // 
            this.buttonToStart.Location = new System.Drawing.Point(312, 88);
            this.buttonToStart.Name = "buttonToStart";
            this.buttonToStart.Size = new System.Drawing.Size(106, 42);
            this.buttonToStart.TabIndex = 3;
            this.buttonToStart.Text = "Vlož na začátek";
            this.buttonToStart.UseVisualStyleBackColor = true;
            this.buttonToStart.Click += new System.EventHandler(this.buttonToStart_Click);
            // 
            // buttonDelLast
            // 
            this.buttonDelLast.Location = new System.Drawing.Point(180, 146);
            this.buttonDelLast.Name = "buttonDelLast";
            this.buttonDelLast.Size = new System.Drawing.Size(106, 42);
            this.buttonDelLast.TabIndex = 5;
            this.buttonDelLast.Text = "Smaž poslední";
            this.buttonDelLast.UseVisualStyleBackColor = true;
            this.buttonDelLast.Click += new System.EventHandler(this.buttonDelLast_Click);
            // 
            // buttonDelFirst
            // 
            this.buttonDelFirst.Location = new System.Drawing.Point(312, 146);
            this.buttonDelFirst.Name = "buttonDelFirst";
            this.buttonDelFirst.Size = new System.Drawing.Size(106, 42);
            this.buttonDelFirst.TabIndex = 4;
            this.buttonDelFirst.Text = "Smaž první";
            this.buttonDelFirst.UseVisualStyleBackColor = true;
            this.buttonDelFirst.Click += new System.EventHandler(this.buttonDelFirst_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(180, 204);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(106, 42);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Setřiď data";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(312, 204);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(106, 42);
            this.buttonWrite.TabIndex = 6;
            this.buttonWrite.Text = "Vypiš";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonDelLast);
            this.Controls.Add(this.buttonDelFirst);
            this.Controls.Add(this.buttonToStart);
            this.Controls.Add(this.buttonToEnd);
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
        private System.Windows.Forms.Button buttonToEnd;
        private System.Windows.Forms.Button buttonToStart;
        private System.Windows.Forms.Button buttonDelLast;
        private System.Windows.Forms.Button buttonDelFirst;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonWrite;
    }
}

