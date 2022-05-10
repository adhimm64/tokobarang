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
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int baris, kolom;
        int[,] arrays;

        private void btnInput_Click(object sender, EventArgs e)
        {
            int row, column, mark;

            row = int.Parse(cbxRow.Text) - 1;
            column = int.Parse(cbxColumn.Text) - 1;
            mark = (int)nudMark.Value;
            lstInfoo.Items.Clear();

            arrays[row, column] = mark;

            for (int i = 0; i < baris; i++)
            {
                string line = "";
                for (int j = 0; j < kolom; j++)
                {
                    line += arrays[i, j] + "\t";
                }
                lstInfoo.Items.Add(line);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int assessment, student, max, average;
            assessment = 1;
            student = 1;
            max = 0;

            if (rbtHighest.Checked)
            {
                if (rbtRows.Checked)
                {
                    lstInfoo.Items.Add("The Highest Mark out of All Students are : ");
                    for (int i = 0; i < baris; i++)
                    {
                        for (int j = 0; j < kolom; j++)
                        {
                            if (max < arrays[i, j])
                            {
                                max = arrays[i, j];
                            }
                        }
                        lstInfoo.Items.Add("Student " + student + " = " + max);
                        student += 1;
                    }
                }

                else
                {
                    lstInfoo.Items.Add("The Highest Mark out of All Assessments are : ");
                    for (int i = 0; i < baris; i++)
                    {
                        for (int j = 0; j < kolom; j++)
                        {
                            if (max < arrays[j, i])
                            {
                                max = arrays[j, i];
                            }
                        }
                        lstInfoo.Items.Add("Assessment " + assessment + " = " + max);
                        assessment += 1;
                    }
                }
            }

            else 
            {
                if (rbtRows.Checked)
                {
                    lstInfoo.Items.Add("The Average Mark of All Student are : ");
                    for (int i = 0; i < baris; i++)
                    {
                        average = 0;
                        for (int j = 0; j < kolom; j++)
                        {
                            average += arrays[i, j];
                        }
                        average = average / kolom;
                        lstInfoo.Items.Add("Student " + student + " = " + average);
                        student += 1;
                    }
                }

                else
                {
                    lstInfoo.Items.Add("The Average Mark of All Assessments are : ");
                    for (int i = 0; i < baris; i++)
                    {
                        average = 0;
                        for (int j = 0; j < kolom; j++)
                        {
                            average += arrays[j, i];
                        }
                        average = average / baris;
                        lstInfoo.Items.Add("Assessment " + assessment + " = " + average);
                        assessment += 1;
                    }
                }
            }
        }

        private void btnInitialze_Click(object sender, EventArgs e)
        {
            baris = int.Parse(txtNumStud.Text);
            kolom = int.Parse(txtNumAsses.Text);
            arrays = new int[baris, kolom];
            lstInfoo.Items.Clear();

            for (int i = 1; i <= baris; i++)
            {
                cbxRow.Items.Add(i);
            }

            for (int i = 1; i <= kolom; i++)
            {
                cbxColumn.Items.Add(i);
            }

            for (int i = 0; i < baris; i++)
            {
                string line = "";
                for (int j = 0; j < kolom; j++)
                {
                    line += arrays[i, j] + "\t";
                }
                lstInfoo.Items.Add(line);
            }
        }
    }
}
