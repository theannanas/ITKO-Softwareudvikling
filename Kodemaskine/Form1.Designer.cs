namespace Kodemaskine
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEnkod = new System.Windows.Forms.Button();
            this.btnDekod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 25);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(341, 98);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 191);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(341, 98);
            this.txtOutput.TabIndex = 1;
            // 
            // btnEnkod
            // 
            this.btnEnkod.Location = new System.Drawing.Point(12, 136);
            this.btnEnkod.Name = "btnEnkod";
            this.btnEnkod.Size = new System.Drawing.Size(75, 23);
            this.btnEnkod.TabIndex = 2;
            this.btnEnkod.Text = "Encode";
            this.btnEnkod.UseVisualStyleBackColor = true;
            this.btnEnkod.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDekod
            // 
            this.btnDekod.Location = new System.Drawing.Point(93, 136);
            this.btnDekod.Name = "btnDekod";
            this.btnDekod.Size = new System.Drawing.Size(75, 23);
            this.btnDekod.TabIndex = 3;
            this.btnDekod.Text = "Decode";
            this.btnDekod.UseVisualStyleBackColor = true;
            this.btnDekod.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Magic number:";
            // 
            // txtTal
            // 
            this.txtTal.Location = new System.Drawing.Point(271, 138);
            this.txtTal.Name = "txtTal";
            this.txtTal.Size = new System.Drawing.Size(82, 20);
            this.txtTal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDekod);
            this.Controls.Add(this.btnEnkod);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Kodemaskine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEnkod;
        private System.Windows.Forms.Button btnDekod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

