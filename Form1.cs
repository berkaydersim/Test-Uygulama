using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Baslıyoruz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Y1, X1, Z1, Y2, X2, Z2, Y3, X3, Z3, DeltaYa, DeltaXa,DeltaYb,DeltaXb,Mesafea, Mesafeb, Mesafeakare, Mesafebkare, Semt_r,Semt_rb,Semt,Semtb,acia;

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        string okuma;
        private void Btnokuma_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Özgür\Desktop\yamacoba-ag.NCN");
            okuma=sr.ReadToEnd();
            RchOkuma.Text = okuma;
        }

        int aci_katsayisi = 200;
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Y1 = Convert.ToDouble(TxtY1.Text);
            X1 = Convert.ToDouble(TxtX1.Text);
            //Z1 = Convert.ToDouble(TxtZ1.Text);
            Y2 = Convert.ToDouble(TxtY2.Text);
            X2 = Convert.ToDouble(TxtX2.Text);
            //Z2 = Convert.ToDouble(TxtZ2.Text);
            Y3 = Convert.ToDouble(TxtY3.Text);
            X3 = Convert.ToDouble(TxtX3.Text);
            //Z3 = Convert.ToDouble(TxtZ3.Text);
            double poo = aci_katsayisi / Math.PI;
            double poo1 = Math.PI / aci_katsayisi;
            DeltaXa = Math.Abs((X1 - X2));
            DeltaYa = Math.Abs((Y1 - Y2));
            DeltaXb = Math.Abs((X2 - X3));
            DeltaYb = Math.Abs((Y2 - Y3));
            Mesafebkare = (DeltaXb * DeltaXb) + (DeltaYb * DeltaYb);
            Mesafeakare = (DeltaXa *DeltaXa) + (DeltaYa*DeltaYa);
            Mesafeb = Math.Sqrt(Mesafebkare);
            Mesafeb = Math.Round(Mesafeb, 2);
            Mesafea = Math.Sqrt(Mesafeakare);
            Mesafea = Math.Round(Mesafea, 2);
            Semt_rb = Math.Atan(DeltaYb / DeltaXb);
            Semt_r = Math.Atan(DeltaYa / DeltaXa);
            Semtb = (Semt_rb / poo1);
            Semt = (Semt_r / poo1);
            DeltaYb = Math.Round(DeltaYb, 3);
            DeltaXb = Math.Round(DeltaXb, 3);
            Semtb = Math.Round(Semtb, 5);
            DeltaYa = Math.Round(DeltaYa, 3);
            DeltaXa = Math.Round(DeltaXa, 3);
            Semt = Math.Round(Semt, 5);
            acia = Math.Abs(Semt - Semtb);
            acia = Math.Round(acia, 5);
            LblDeltaX.Text = DeltaXa.ToString();
            LblDeltaY.Text = DeltaYa.ToString();
            RchHesap.AppendText("1-2 Direk Arası: " + " ΔX:" + DeltaXa.ToString() + " ΔY:" + DeltaYa.ToString()+" Mesafe:"+Mesafea.ToString()+" Semt:"+Semt.ToString()+"\n");
            RchHesap.AppendText("2-3 Direk Arası: " + " ΔX:" + DeltaXb.ToString() + " ΔY:" + DeltaYb.ToString() + " Mesafe:" + Mesafeb.ToString() + " Semt:" + Semtb.ToString() +" "+"2.Direk Açısı: "+acia.ToString()+"\n");
            LblSemt.Text = Semt.ToString();
        }
    }
}
