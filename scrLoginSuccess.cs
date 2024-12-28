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
        public scrLoginSuccess()
        {
            InitializeComponent();
        }

        private void btnExitL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
