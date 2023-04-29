using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private const int rows = 3;
        private const int cols = 4;
        private int[,] arr = new int[rows, cols];
        Random random= new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] minArr = new int[rows];
            for(int i = 0; i < rows; i++)
            {
                int min = arr[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if(min > arr[i, j])
                        min = arr[i, j];
                }
                minArr[i] = min;
            }
            for(int i = 0; i < minArr.Length; i++)
                label2.Text += $"Минимальное значение в {i+1} строке: {minArr[i]}\n";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 4;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = random.Next(100);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }
    }
}
