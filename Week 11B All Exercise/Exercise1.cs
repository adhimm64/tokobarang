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
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        int baris, kolom;
        double[,] array2D;
        public void btnInitialze_Click(object sender, EventArgs e)
        {
            baris = int.Parse(txtNumStud.Text);
            kolom = int.Parse(txtNumAsses.Text);
            array2D = new double[baris, kolom];
            lstInfoo.Items.Clear();

            for (int i = 1; i <= baris; i++)
            {
                cbxRow.Items.Add(i);
            }

            for (int i = 1; i <= kolom; i++)
            {
                cbxColumn.Items.Add(i);
            }

            for (int row = 0; row < baris; row++)
            {
                string line = "";
                for (int column = 0; column < kolom; column++)
                {
                    line += array2D[row, column] + "\t";
                }
                lstInfoo.Items.Add(line);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnInput_Click(object sender, EventArgs e)
        {
            int angkaBaris, angkaKolom, nilai;

            angkaBaris = int.Parse(cbxRow.Text) - 1;
            angkaKolom = int.Parse(cbxColumn.Text) - 1;
            nilai = (int)nudMark.Value;
            lstInfoo.Items.Clear();

            array2D[angkaBaris, angkaKolom] = nilai;

            for (int row = 0; row < baris; row++)
            {
                string line = "";
                for (int column = 0; column < kolom; column++)
                {
                    line += array2D[row, column] + "\t";
                }
                lstInfoo.Items.Add(line);
            }
        } 
    }
}
