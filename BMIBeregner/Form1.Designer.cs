namespace BMIBeregner
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cmdBeregnBMI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinVaegt = new System.Windows.Forms.TextBox();
            this.txtMaxVaegt = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtVaegt = new System.Windows.Forms.TextBox();
            this.txtHoejde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdBeregnBMI
            // 
            this.cmdBeregnBMI.Location = new System.Drawing.Point(27, 74);
            this.cmdBeregnBMI.Name = "cmdBeregnBMI";
            this.cmdBeregnBMI.Size = new System.Drawing.Size(75, 23);
            this.cmdBeregnBMI.TabIndex = 0;
            this.cmdBeregnBMI.Text = "Beregn BMI";
            this.cmdBeregnBMI.UseVisualStyleBackColor = true;
            this.cmdBeregnBMI.Click += new System.EventHandler(this.cmdBeregnBMI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Højde (i meter)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vægt (i kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Min. vægt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max vægt";
            // 
            // txtMinVaegt
            // 
            this.txtMinVaegt.Location = new System.Drawing.Point(27, 234);
            this.txtMinVaegt.Name = "txtMinVaegt";
            this.txtMinVaegt.ReadOnly = true;
            this.txtMinVaegt.Size = new System.Drawing.Size(100, 20);
            this.txtMinVaegt.TabIndex = 6;
            // 
            // txtMaxVaegt
            // 
            this.txtMaxVaegt.Location = new System.Drawing.Point(154, 234);
            this.txtMaxVaegt.Name = "txtMaxVaegt";
            this.txtMaxVaegt.ReadOnly = true;
            this.txtMaxVaegt.Size = new System.Drawing.Size(100, 20);
            this.txtMaxVaegt.TabIndex = 7;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(27, 173);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.ReadOnly = true;
            this.txtBMI.Size = new System.Drawing.Size(100, 20);
            this.txtBMI.TabIndex = 8;
            // 
            // txtVaegt
            // 
            this.txtVaegt.Location = new System.Drawing.Point(154, 48);
            this.txtVaegt.Name = "txtVaegt";
            this.txtVaegt.Size = new System.Drawing.Size(100, 20);
            this.txtVaegt.TabIndex = 9;
            // 
            // txtHoejde
            // 
            this.txtHoejde.Location = new System.Drawing.Point(27, 48);
            this.txtHoejde.Name = "txtHoejde";
            this.txtHoejde.Size = new System.Drawing.Size(100, 20);
            this.txtHoejde.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 287);
            this.Controls.Add(this.txtHoejde);
            this.Controls.Add(this.txtVaegt);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtMaxVaegt);
            this.Controls.Add(this.txtMinVaegt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBeregnBMI);
            this.Name = "Form1";
            this.Text = "Beregn BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBeregnBMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinVaegt;
        private System.Windows.Forms.TextBox txtMaxVaegt;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtVaegt;
        private System.Windows.Forms.TextBox txtHoejde;
    }
}

