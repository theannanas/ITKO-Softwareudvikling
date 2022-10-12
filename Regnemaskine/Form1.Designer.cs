namespace Regnemaskine
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnProcent = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtTal1 = new System.Windows.Forms.TextBox();
            this.txtTal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(227, 12);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnProcent
            // 
            this.btnProcent.Location = new System.Drawing.Point(227, 128);
            this.btnProcent.Name = "btnProcent";
            this.btnProcent.Size = new System.Drawing.Size(75, 23);
            this.btnProcent.TabIndex = 2;
            this.btnProcent.Text = "%";
            this.btnProcent.UseVisualStyleBackColor = true;
            this.btnProcent.Click += new System.EventHandler(this.btnProcent_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(227, 99);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 3;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(227, 70);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(227, 41);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // txtTal1
            // 
            this.txtTal1.Location = new System.Drawing.Point(100, 71);
            this.txtTal1.Name = "txtTal1";
            this.txtTal1.Size = new System.Drawing.Size(100, 22);
            this.txtTal1.TabIndex = 6;
            // 
            // txtTal2
            // 
            this.txtTal2.Location = new System.Drawing.Point(319, 71);
            this.txtTal2.Name = "txtTal2";
            this.txtTal2.Size = new System.Drawing.Size(100, 22);
            this.txtTal2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(474, 74);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(28, 16);
            this.lblRes.TabIndex = 10;
            this.lblRes.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 217);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTal2);
            this.Controls.Add(this.txtTal1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnProcent);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Regnemaskine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnProcent;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox txtTal1;
        private System.Windows.Forms.TextBox txtTal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblRes;
    }
}

