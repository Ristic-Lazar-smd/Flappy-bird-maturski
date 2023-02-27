using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird_maturski_rad
{
    public partial class Form2 : Form
    {
             
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            label1.Text = Form1.fscore.ToString();          
        }

        private void Label4_Click(object sender, EventArgs e)
        {        
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
               
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
