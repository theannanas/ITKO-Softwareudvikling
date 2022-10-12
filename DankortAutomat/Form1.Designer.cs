namespace DankortAutomat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTjekPin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtNavn = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBeloeb = new System.Windows.Forms.TextBox();
            this.btnGodkend = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.txtKontobevaegelser = new System.Windows.Forms.TextBox();
            this.btnVisBevaegelser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNulstil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indtast pinkode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Navn:";
            // 
            // btnTjekPin
            // 
            this.btnTjekPin.Location = new System.Drawing.Point(174, 6);
            this.btnTjekPin.Name = "btnTjekPin";
            this.btnTjekPin.Size = new System.Drawing.Size(75, 23);
            this.btnTjekPin.TabIndex = 3;
            this.btnTjekPin.Text = "Tjek";
            this.btnTjekPin.UseVisualStyleBackColor = true;
            this.btnTjekPin.Click += new System.EventHandler(this.btnTjekPin_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(112, 6);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(56, 20);
            this.txtPin.TabIndex = 4;
            // 
            // txtNavn
            // 
            this.txtNavn.Location = new System.Drawing.Point(66, 60);
            this.txtNavn.Name = "txtNavn";
            this.txtNavn.ReadOnly = true;
            this.txtNavn.Size = new System.Drawing.Size(183, 20);
            this.txtNavn.TabIndex = 5;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(66, 34);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(183, 20);
            this.txtSaldo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNulstil);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBeloeb);
            this.groupBox1.Controls.Add(this.btnGodkend);
            this.groupBox1.Controls.Add(this.btn1000);
            this.groupBox1.Controls.Add(this.btn500);
            this.groupBox1.Controls.Add(this.btn200);
            this.groupBox1.Controls.Add(this.btn100);
            this.groupBox1.Location = new System.Drawing.Point(26, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vælg beløb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beløb:";
            // 
            // txtBeloeb
            // 
            this.txtBeloeb.Location = new System.Drawing.Point(122, 96);
            this.txtBeloeb.Name = "txtBeloeb";
            this.txtBeloeb.ReadOnly = true;
            this.txtBeloeb.Size = new System.Drawing.Size(75, 20);
            this.txtBeloeb.TabIndex = 5;
            // 
            // btnGodkend
            // 
            this.btnGodkend.Location = new System.Drawing.Point(122, 122);
            this.btnGodkend.Name = "btnGodkend";
            this.btnGodkend.Size = new System.Drawing.Size(75, 23);
            this.btnGodkend.TabIndex = 4;
            this.btnGodkend.Text = "Godkend";
            this.btnGodkend.UseVisualStyleBackColor = true;
            this.btnGodkend.Click += new System.EventHandler(this.btnGodkend_Click);
            // 
            // btn1000
            // 
            this.btn1000.Location = new System.Drawing.Point(122, 48);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(75, 23);
            this.btn1000.TabIndex = 3;
            this.btn1000.Text = "1000 kr";
            this.btn1000.UseVisualStyleBackColor = true;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn500
            // 
            this.btn500.Location = new System.Drawing.Point(24, 48);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(75, 23);
            this.btn500.TabIndex = 2;
            this.btn500.Text = "500 kr";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(122, 19);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(75, 23);
            this.btn200.TabIndex = 1;
            this.btn200.Text = "200 kr";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(24, 19);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 0;
            this.btn100.Text = "100 kr";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // txtKontobevaegelser
            // 
            this.txtKontobevaegelser.Location = new System.Drawing.Point(26, 287);
            this.txtKontobevaegelser.Multiline = true;
            this.txtKontobevaegelser.Name = "txtKontobevaegelser";
            this.txtKontobevaegelser.ReadOnly = true;
            this.txtKontobevaegelser.Size = new System.Drawing.Size(223, 92);
            this.txtKontobevaegelser.TabIndex = 8;
            // 
            // btnVisBevaegelser
            // 
            this.btnVisBevaegelser.Location = new System.Drawing.Point(26, 385);
            this.btnVisBevaegelser.Name = "btnVisBevaegelser";
            this.btnVisBevaegelser.Size = new System.Drawing.Size(223, 23);
            this.btnVisBevaegelser.TabIndex = 9;
            this.btnVisBevaegelser.Text = "Vis bevægelser";
            this.btnVisBevaegelser.UseVisualStyleBackColor = true;
            this.btnVisBevaegelser.Click += new System.EventHandler(this.btnVisBevaegelser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kontobevægelser";
            // 
            // btnNulstil
            // 
            this.btnNulstil.Location = new System.Drawing.Point(24, 122);
            this.btnNulstil.Name = "btnNulstil";
            this.btnNulstil.Size = new System.Drawing.Size(75, 23);
            this.btnNulstil.TabIndex = 7;
            this.btnNulstil.Text = "Nulstil";
            this.btnNulstil.UseVisualStyleBackColor = true;
            this.btnNulstil.Click += new System.EventHandler(this.btnNulstil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVisBevaegelser);
            this.Controls.Add(this.txtKontobevaegelser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNavn);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnTjekPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dankortautomat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTjekPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtNavn;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBeloeb;
        private System.Windows.Forms.Button btnGodkend;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKontobevaegelser;
        private System.Windows.Forms.Button btnVisBevaegelser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNulstil;
    }
}

