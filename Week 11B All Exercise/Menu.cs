using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_11B_All_Exercise
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercise1 exercise1 = new Exercise1();
            exercise1.Owner = this;
            exercise1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercise2 exercise2 = new Exercise2();
            exercise2.Owner = this;
            exercise2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
