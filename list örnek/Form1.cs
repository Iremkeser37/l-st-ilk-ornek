using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_örnek
{
    public partial class Form1 : Form
    {
        List <int> sayılar = new List <int> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int sayi = Convert.ToInt32(textBox1.Text);
           sayılar.Add (sayi);
            lblSayilar.DataSource = sayılar.ToList();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

            
        }
    }
}
