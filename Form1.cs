using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisIndirim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { //butona tıklandığında 
            int adet;
            adet = Convert.ToInt32(textBox1.Text); //girilen değeri sayısal değere çevirir
            double toplam;
            if (adet>0 && adet<= 20) //adet 0 dan büyük ve 20 küçük esit ise 
            {
                toplam = (adet * 8) - (adet * 8 * 0.2); //0.2 değerinde indirim uygula fiyattan 
                label3.Text = toplam + " ₺";
            }
            else if (adet>20 && adet<=40) //adet 20 den büyük olduğu ve 40'a küçük esit ise
            {
                toplam = (adet * 8) - (adet * 8 * 0.4); //0.4 değerinde indirim uygula fiyattan
                label3.Text = toplam + " ₺";
            }
            else
            {
               toplam = (adet * 8) - (adet * 8 * 0.5); //0.5 değerinde indirim uygula fiyattan
                label3.Text = toplam + " ₺";
            }
        }
    }
}
