namespace myPaint
{
    partial class myFormPen
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.lkol = new System.Windows.Forms.Label();
            this.lblSzerokosc = new System.Windows.Forms.Label();
            this.lblStylLinii = new System.Windows.Forms.Label();
            this.lblKolor = new System.Windows.Forms.Label();
            this.kolorDlg = new System.Windows.Forms.ColorDialog();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(217, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(323, 227);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 1;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // lkol
            // 
            this.lkol.AutoSize = true;
            this.lkol.Location = new System.Drawing.Point(36, 38);
            this.lkol.Name = "lkol";
            this.lkol.Size = new System.Drawing.Size(31, 13);
            this.lkol.TabIndex = 2;
            this.lkol.Text = "Kolor";
            // 
            // lblSzerokosc
            // 
            this.lblSzerokosc.AutoSize = true;
            this.lblSzerokosc.Location = new System.Drawing.Point(36, 95);
            this.lblSzerokosc.Name = "lblSzerokosc";
            this.lblSzerokosc.Size = new System.Drawing.Size(57, 13);
            this.lblSzerokosc.TabIndex = 3;
            this.lblSzerokosc.Text = "Szerokosc";
            // 
            // lblStylLinii
            // 
            this.lblStylLinii.AutoSize = true;
            this.lblStylLinii.Location = new System.Drawing.Point(36, 144);
            this.lblStylLinii.Name = "lblStylLinii";
            this.lblStylLinii.Size = new System.Drawing.Size(42, 13);
            this.lblStylLinii.TabIndex = 4;
            this.lblStylLinii.Text = "StylLinii";
            // 
            // lblKolor
            // 
            this.lblKolor.BackColor = System.Drawing.Color.Black;
            this.lblKolor.Location = new System.Drawing.Point(136, 38);
            this.lblKolor.Name = "lblKolor";
            this.lblKolor.Size = new System.Drawing.Size(57, 23);
            this.lblKolor.TabIndex = 5;
            this.lblKolor.Click += new System.EventHandler(this.lblKolor_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(139, 87);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(54, 20);
            this.txtWidth.TabIndex = 6;
            this.txtWidth.Text = "1";
            // 
            // myFormPen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 262);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblKolor);
            this.Controls.Add(this.lblStylLinii);
            this.Controls.Add(this.lblSzerokosc);
            this.Controls.Add(this.lkol);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnOK);
            this.Name = "myFormPen";
            this.Text = "myFormPen";
            this.Load += new System.EventHandler(this.myFormPen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Label lkol;
        private System.Windows.Forms.Label lblSzerokosc;
        private System.Windows.Forms.Label lblStylLinii;
        private System.Windows.Forms.Label lblKolor;
        private System.Windows.Forms.ColorDialog kolorDlg;
        private System.Windows.Forms.TextBox txtWidth;
    }
}