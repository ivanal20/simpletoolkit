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
    public partial class frmWingetGUI : Form
    {
        public frmWingetGUI()
        {
            InitializeComponent();
        }
    }

    public class AppInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AppId { get; set; }
    }

    //public static List<AppInfo> GetAppsList() { return "OK"; }
}
