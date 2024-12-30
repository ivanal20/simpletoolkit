using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpletoolkit
{
    public partial class scrLoginSuccess : UserControl
    {
        //String[] loadingAnim = [ "","","","","","","","" ];
        int currentChar;
        int counter = 0;
        frmLoginUI frmLoginUI = new frmLoginUI();
        frmMain frmMain = new frmMain();
        public scrLoginSuccess()
        {
            InitializeComponent();
        }

        private void btnExitL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scrLoginSuccess_Load(object sender, EventArgs e)
        {
            currentChar = 0xE052;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLoading.Text = char.ConvertFromUtf32(currentChar);
            currentChar++;
            if (currentChar > 0xE0C8)
            {
                currentChar = 0xE052;
                counter++;
            }
            if (counter == 2)
            {
                frmLoginUI.Close();
                frmMain.Show();
            }
        }
    }
}
