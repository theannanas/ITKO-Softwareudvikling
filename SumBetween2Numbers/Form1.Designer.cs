namespace SumBetween2Numbers
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
            this.cmdBeregnSumAfTalMellem1Og200 = new System.Windows.Forms.Button();
            this.cmdBeregnSumAfTalMellem1ogX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumAfTalMellem1og200 = new System.Windows.Forms.TextBox();
            this.txtSumAfTalMellem1ogX = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdBeregnSumAfTalMellem1Og200
            // 
            this.cmdBeregnSumAfTalMellem1Og200.Location = new System.Drawing.Point(27, 62);
            this.cmdBeregnSumAfTalMellem1Og200.Name = "cmdBeregnSumAfTalMellem1Og200";
            this.cmdBeregnSumAfTalMellem1Og200.Size = new System.Drawing.Size(243, 23);
            this.cmdBeregnSumAfTalMellem1Og200.TabIndex = 0;
            this.cmdBeregnSumAfTalMellem1Og200.Text = "Beregn sum af tal mellem 1 og 200";
            this.cmdBeregnSumAfTalMellem1Og200.UseVisualStyleBackColor = true;
            this.cmdBeregnSumAfTalMellem1Og200.Click += new System.EventHandler(this.CmdBeregnSumAfTalMellem1Og200_Click);
            // 
            // cmdBeregnSumAfTalMellem1ogX
            // 
            this.cmdBeregnSumAfTalMellem1ogX.Location = new System.Drawing.Point(27, 179);
            this.cmdBeregnSumAfTalMellem1ogX.Name = "cmdBeregnSumAfTalMellem1ogX";
            this.cmdBeregnSumAfTalMellem1ogX.Size = new System.Drawing.Size(243, 23);
            this.cmdBeregnSumAfTalMellem1ogX.TabIndex = 1;
            this.cmdBeregnSumAfTalMellem1ogX.Text = "Beregn sum af tal mellem 1 og x";
            this.cmdBeregnSumAfTalMellem1ogX.UseVisualStyleBackColor = true;
            this.cmdBeregnSumAfTalMellem1ogX.Click += new System.EventHandler(this.CmdBeregnSumAfTalMellem1ogX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sum af tal mellem 1 og 200:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // txtSumAfTalMellem1og200
            // 
            this.txtSumAfTalMellem1og200.Location = new System.Drawing.Point(170, 99);
            this.txtSumAfTalMellem1og200.Name = "txtSumAfTalMellem1og200";
            this.txtSumAfTalMellem1og200.ReadOnly = true;
            this.txtSumAfTalMellem1og200.Size = new System.Drawing.Size(100, 20);
            this.txtSumAfTalMellem1og200.TabIndex = 4;
            // 
            // txtSumAfTalMellem1ogX
            // 
            this.txtSumAfTalMellem1ogX.Location = new System.Drawing.Point(170, 269);
            this.txtSumAfTalMellem1ogX.Name = "txtSumAfTalMellem1ogX";
            this.txtSumAfTalMellem1ogX.ReadOnly = true;
            this.txtSumAfTalMellem1ogX.Size = new System.Drawing.Size(100, 20);
            this.txtSumAfTalMellem1ogX.TabIndex = 5;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(170, 220);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtSumAfTalMellem1ogX);
            this.Controls.Add(this.txtSumAfTalMellem1og200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBeregnSumAfTalMellem1ogX);
            this.Controls.Add(this.cmdBeregnSumAfTalMellem1Og200);
            this.Name = "Form1";
            this.Text = "Sum af tal mellem 1 og x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBeregnSumAfTalMellem1Og200;
        private System.Windows.Forms.Button cmdBeregnSumAfTalMellem1ogX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumAfTalMellem1og200;
        private System.Windows.Forms.TextBox txtSumAfTalMellem1ogX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
    }
}

