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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        public static frm_StuFind mainframe1 = new frm_StuFind();
        public static Form_Registration mainframe2 = new Form_Registration();
        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Loginin_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="admin")
            {
                mainframe1.BringToFront();
                mainframe1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码错误！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }   

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.btn_Loginin_Click(sender, e);
            }
        }
    }
}
