using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanWinForm
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void btnWordMgt_Click(object sender, EventArgs e)
        {
            Form frmWordManagement = new FrmWordManagement();
            frmWordManagement.ShowDialog();
        }

        private void FrmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
            this.Close();
        }
    }
}
