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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            OpenNewForm(new FrmNewGame());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenNewForm(new FrmSetting());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void OpenNewForm(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
