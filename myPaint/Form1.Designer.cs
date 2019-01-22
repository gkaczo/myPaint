namespace myPaint
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
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.loadDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnCircle = new System.Windows.Forms.Button();
            this.kolorDlg = new System.Windows.Forms.ColorDialog();
            this.lblKolor = new System.Windows.Forms.Label();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.btnPioro = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.Color.White;
            this.pctBox.Location = new System.Drawing.Point(221, 38);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(337, 310);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseClick);
            this.pctBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseDown);
            this.pctBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseMove);
            this.pctBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Czyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "bmp|*.jpg";
            this.saveDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDlg_FileOk);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(113, 289);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // loadDlg
            // 
            this.loadDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.loadDlg_FileOk);
            // 
            // btnCircle
            // 
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCircle.Location = new System.Drawing.Point(461, 3);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(60, 29);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // lblKolor
            // 
            this.lblKolor.BackColor = System.Drawing.Color.Black;
            this.lblKolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKolor.Location = new System.Drawing.Point(221, 12);
            this.lblKolor.Name = "lblKolor";
            this.lblKolor.Size = new System.Drawing.Size(44, 23);
            this.lblKolor.TabIndex = 5;
            this.lblKolor.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbWidth.Location = new System.Drawing.Point(272, 12);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(60, 21);
            this.cmbWidth.TabIndex = 6;
            this.cmbWidth.Text = "1";
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_SelectedIndexChanged);
            // 
            // btnPioro
            // 
            this.btnPioro.Location = new System.Drawing.Point(13, 60);
            this.btnPioro.Name = "btnPioro";
            this.btnPioro.Size = new System.Drawing.Size(75, 23);
            this.btnPioro.TabIndex = 7;
            this.btnPioro.Text = "Pioro";
            this.btnPioro.UseVisualStyleBackColor = true;
            this.btnPioro.Click += new System.EventHandler(this.btnPioro_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(389, 3);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(55, 29);
            this.btnTriangle.TabIndex = 8;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 351);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnPioro);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.lblKolor);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pctBox);
            this.Name = "Form1";
            this.Text = "myPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog loadDlg;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.ColorDialog kolorDlg;
        private System.Windows.Forms.Label lblKolor;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.Button btnPioro;
        private System.Windows.Forms.Button btnTriangle;
    }
}

