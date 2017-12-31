using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class frm_StuFind : Form
    {
        public frm_StuFind()
        {
            InitializeComponent();
        }
        Form_Registration registData = new Form_Registration();
        private PrintDocument printDocument;
        private void btn_Find_Click(object sender, EventArgs e)
        {
            txt_Xibu2.Text = cbo_Xibu.Text;
            txt_Banji2.Text = cbo_Banji.Text;
            txt_Name2.Text = txt_Name.Text;
            txt_Numb2.Text = txt_Numb.Text;
            txt_Sex2.Text = txt_Sex.Text;
            txt_ID.Text = "2w31423432";
            txt_EmailAddress.Text = "12345@Gmail.com";
            txt_PhoneNumber.Text = "13000000000";
            txt_Health.Text = "nice";
            if(rbtn_Zhongqiao.Checked)
            {
                txt_Xiaoqu.Text = "中桥校区";
            }
            if (rbtn_Taihu.Checked)
            {
                txt_Xiaoqu.Text = "太湖校区";
            }
            if (rbtn_Meiyuan.Checked)
            {
                txt_Xiaoqu.Text = "梅园校区";
            }
            if(rbtn_Zaixiao.Checked)
            {
                txt_Leibie.Text = "在校学生";
            }
            if (rBtn_Biye.Checked)
            {
                txt_Leibie.Text = "毕业学生";
            }
            if (rbtn_Xiuxue.Checked)
            {
                txt_Leibie.Text = "休学学生";
            }
            pic_Photo.Load("..\\..\\ico.jpg");
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            frm_Login.mainframe2.BringToFront();
            frm_Login.mainframe2.Show();
            this.Close();
        }

        private void frm_StuFind_Load(object sender, EventArgs e)
        {       
        }

        private void lst_Data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog = new PrintDialog();
            printdialog.Document = printDocument;
            printdialog.ShowDialog();
        }
    }
}
