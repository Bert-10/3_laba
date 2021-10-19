using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.s1.ToString();
            textBox3.Text = Properties.Settings.Default.s2.ToString();
            textBox2.Text = Properties.Settings.Default.outText.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int c;
            string s1,s2;
            s1 = textBox1.Text;
            s2 = textBox2.Text;
            string[] subs = s1.Split(' ');
            string[] subs_1 = s2.Split(' ');
            int[] a = new int[subs.Length];
            int[] b = new int[subs_1.Length];
            try
            {
                
                for (int i = 0; i < subs.Length; i++)
                {
                    a[i]= int.Parse(subs[i]);
                    
                }
                for (int i = 0; i < subs_1.Length; i++)
                {
                    b[i]=int.Parse(subs_1[i]);
                }
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод. В поля можно вводить только числа и пробелы между ними (в конце и в начале пробелы запрещены).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return; // а затем прерываем обработчик
            }

            switch (comboBox1.Text)
            {
                case "сумма множеств/сумма множества и числа":
                    textBox3.Text = Many.OpPlus(a, b);
                    break;

                case "пересечение двух множеств":
                    textBox3.Text = Many.Union(a, b);
                    break;

                case "разность двух множеств/разность множества и числа":
                    textBox3.Text = Many.difference(a, b);
                    break;
            }

            Properties.Settings.Default.s1 = s1;
            Properties.Settings.Default.s2 = s2;
            Properties.Settings.Default.outText = textBox3.Text;
            Properties.Settings.Default.Save();
            //   textBox3.Text = outText;


        }
 


    }
}
