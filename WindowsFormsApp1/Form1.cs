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
    public partial class Form1 : Form
    {
        private static string first = string.Empty;
        private int zeros;
        private int ones;

        private static string second = string.Empty;
        private int countOfWords;

        private static string fourth = string.Empty;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                first += listBox1.Items[i].ToString();
            }
            for(int i = 0; i < first.Length; i++) 
            {
                if (first[i] == '1')
                {
                    ones++;
                }
                else if (first[i] == '0')
                {
                    zeros++;
                }
            }
            label2.Text = $"Нулей: {zeros}\nЕдиниц: {ones}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                second += listBox2.Items[i].ToString();
            }
            countOfWords = second.Split(new char[] { ' ' }).Length;
            label3.Text = $"В строке {countOfWords} слов(а)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            for(int i = 0; i < listBox3.Items.Count; i++)
            {
                fourth += listBox3.Items[i].ToString();
            }
            for(int i = 0; i < fourth.Length; i++)
            {
                if (fourth[i] >= 48 && fourth[i] <= 57) 
                {
                    result += fourth[i].ToString();
                }
            }
            label6.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
