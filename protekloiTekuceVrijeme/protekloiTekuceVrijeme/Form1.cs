using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protekloiTekuceVrijeme
{
    public partial class Form1 : Form
    {
        DateTime pocetno;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetno = DateTime.Now;
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel2.Text = "Proteklo: " + proteklo.Hours.ToString() +":"+ proteklo.Minutes.ToString() +":"+ proteklo.Seconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = pocetno.ToString();
        }
    }
}
