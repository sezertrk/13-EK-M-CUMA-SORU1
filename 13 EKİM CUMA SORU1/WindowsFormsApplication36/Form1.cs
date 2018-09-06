using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kod = Convert.ToInt16(textBox3.Text);
            double apara = int.Parse(textBox4.Text);
            double aylik = int.Parse(textBox5.Text);
            double faiz = 0; 
            
            if (kod == 1)
            {
                faiz = apara * 4 / 100;
                faiz = faiz * aylik;
                textBox6 .Text = (faiz +apara ).ToString ();
                textBox7.Text = ((faiz + apara) / aylik).ToString();
            }
            else if (kod == 2)
            {
                faiz = apara * 4 / 100;
                faiz = faiz * aylik;
                textBox6.Text = (faiz + apara).ToString();
                textBox7.Text = ((faiz + apara) / aylik).ToString();
            }
            else {MessageBox .Show ("Hatalı Kod Girdiniz");}
            {
                
            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox .Show (textBox1 .Text + " " + textBox2 .Text + " adlı kişinin bankamızdan almış olduğu " + textBox4 .Text + " liralık kredi " + textBox5 .Text + " ayda, " + textBox7 .Text + " taksitlerle toplam: " + textBox6 .Text + " olarak ödeyecektir, " + " Bilgilendirme " + MessageBoxButtons .OK + MessageBoxIcon .Information);
        }

      
                      
        }
    }
 
