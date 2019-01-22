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
    public partial class Form1 : Form
    {
        private Graphics graph;
        private Point punkt = Point.Empty;
        private Pen pioro;


        private Point punkt2 = Point.Empty;
       // private Rectangle rect; // do kola
        private bool kolo;
        private bool trojkat;

        private Point punkt3 = Point.Empty;
        

        public Form1()
        {
            InitializeComponent();
            pctBox.Image = new Bitmap(pctBox.Size.Width,pctBox.Size.Height);
            graph = Graphics.FromImage(pctBox.Image);
            pioro = new Pen(Color.Black);                    
            kolo = false;
            trojkat = false;        

        }

        private void pctBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                punkt = e.Location;
          
           
        }

        private void pctBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (kolo == false && trojkat==false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    graph.DrawLine(pioro, punkt, e.Location);
                    punkt = e.Location;
                    pctBox.Refresh();

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            pctBox.Refresh();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDlg.ShowDialog();
            if (saveDlg.FileName != "")
            {
                pctBox.Image.Save(saveDlg.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadDlg.ShowDialog();
            if (loadDlg.FileName != "")
            {

                Bitmap bmp = new Bitmap(loadDlg.FileName);
                Bitmap bmp1 = new Bitmap(bmp, pctBox.Size.Width, pctBox.Size.Height);

                graph.DrawImage(bmp1, pctBox.Size.Width / bmp.Width, pctBox.Size.Height / bmp.Height);
                
            }

            pctBox.Refresh();

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            if (kolo == false)
            {
                btnCircle.FlatStyle = FlatStyle.Popup;
                kolo = true;
            }
            else
            {
                btnCircle.FlatStyle = FlatStyle.Standard;
                kolo = false;
            }
        }

        private void pctBox_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (kolo == true)
            {
               
                if (e.Button == MouseButtons.Left)
                { 
                    punkt2 = e.Location;
                    Rectangle rect = new Rectangle(punkt.X, punkt.Y, punkt2.X, punkt2.Y);
                    graph.DrawEllipse(pioro, rect);
                    
                    pctBox.Refresh();
                   
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (kolorDlg.ShowDialog() == DialogResult.OK)
            {
                lblKolor.BackColor = kolorDlg.Color;
                pioro.Color = kolorDlg.Color;
                
            }

           

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtWidth_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtWidth_TextChanged_1(object sender, EventArgs e)
        {
           // pioro.Width = float.Parse(txtWidth.Text);
        }

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cmbWidth.SelectedItem.ToString());
            pioro.Width = float.Parse(cmbWidth.SelectedItem.ToString());
        }

        private void btnPioro_Click(object sender, EventArgs e)
        {
            pioro.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            float s;
            myFormPen PenDlg = new myFormPen();
            PenDlg.Kolor = pioro.Color;
            PenDlg.Szerokosc = pioro.Width;
            if (PenDlg.ShowDialog() == DialogResult.OK)
            {
                lblKolor.BackColor = PenDlg.Kolor;
                pioro.Color = PenDlg.Kolor;

                s = PenDlg.Szerokosc;
                cmbWidth.Text = s.ToString();
                pioro.Width = s;
               // MessageBox.Show(PenDlg.Szerokosc.ToString());
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            if (trojkat == false)
            {
                btnTriangle.FlatStyle = FlatStyle.Popup;
                trojkat = true;
            }
            else
            {
                btnTriangle.FlatStyle = FlatStyle.Standard;
                trojkat = false;
            }

        }
        private void RysujTrojkat(Point punkt)
        {
            if (punkt2.IsEmpty==true)
            {
              //  MessageBox.Show(punkt2.ToString());
                punkt2 = punkt;
               // punkt = Point.Empty;


            }
            else
            if (punkt3.IsEmpty==true)
            {
               // MessageBox.Show("3:"+punkt3.ToString());
                punkt3 = punkt;
              //  punkt = Point.Empty;
            }
            else
            if (!punkt.IsEmpty && !punkt2.IsEmpty && !punkt3.IsEmpty)
            {
                //MessageBox.Show(punkt2.X.ToString());
               // MessageBox.Show(punkt.ToString());
                graph.DrawLine(pioro, punkt, punkt2);
                graph.DrawLine(pioro, punkt2, punkt3);
                graph.DrawLine(pioro, punkt3, punkt);
                pctBox.Refresh();
                punkt = Point.Empty;
                punkt2 = Point.Empty;
                punkt3 = Point.Empty;

            }
        }
        private void pctBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (trojkat == true)
            {
                if (e.Button == MouseButtons.Left)
                RysujTrojkat(e.Location);
            }
        }

        private void loadDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveDlg_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
