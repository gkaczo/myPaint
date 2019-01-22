using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myPaint
{
    public partial class myFormPen : Form
    {
        public Color Kolor;
        public float Szerokosc;
        public myFormPen()
        {
            Kolor = Color.Black;
            Szerokosc = 1.0f;
            InitializeComponent();
            
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Szerokosc = float.Parse(txtWidth.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void lblKolor_Click(object sender, EventArgs e)
        {
            if (kolorDlg.ShowDialog() == DialogResult.OK)
            {
                lblKolor.BackColor = kolorDlg.Color;
                Kolor = kolorDlg.Color;
            }
        }

        private void ZaladujUstawieniaPoczatkowe()
        {
            lblKolor.BackColor = Kolor;
            txtWidth.Text = Szerokosc.ToString();
        }


        private void myFormPen_Load(object sender, EventArgs e)
        {
            ZaladujUstawieniaPoczatkowe();
            
        }
    }
}
