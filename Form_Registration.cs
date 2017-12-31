using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class Form_Registration : Form
    {
        public Form_Registration()
        {
            InitializeComponent();
        }
        public static string info;

        private void Form_Registration_Load(object sender, EventArgs e)
        {
            lbl_Timer.Text = DateTime.Now.ToString();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info = textBox1.Text + " " + radioButton1.Text + " " + textBox2.Text + " " + textBox3.Text + " " +
                textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " " + textBox7.Text + " " +
                comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text + " " + textBox8.Text + " ";
            listBox1.Items.Add(info);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();    
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            frm_StuFind form2 = new frm_StuFind();
            foreach (var item in listBox1.Items)
            {
                form2.lst_Data.Items.Add(item);
                Console.WriteLine(item);
            }
            this.Hide();
            form2.Show();
        }
    }
}
