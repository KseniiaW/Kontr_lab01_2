using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontr_lab01_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click_1(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
