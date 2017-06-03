using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_BHST;
namespace QUANLY_BHST.VIEW
{
    public partial class FromHelp : Form
    {
        public FromHelp()
        {
            InitializeComponent();
        }

        private void FromHelp_Load(object sender, EventArgs e)
        {

        }

        private void TVHelp_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TVHelp_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Hướng Dẫn Cài Đặt")
                webBrowser1.Navigate(@"C:\Users\DELL\Documents\Hướng dẫn cài đặt phần mềm.htm");
          
                if(e.Node.Text == "Hướng Dẫn Sử Dụng") ;
                webBrowser1.Navigate(@"C:\Users\DELL\Documents\Hướng Dẫn Sử Dụng Phần Mềm.htm");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
             FormMain a = new FormMain();
            a.Show();
        }
    }
}
