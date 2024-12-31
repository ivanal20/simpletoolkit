using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace simpletoolkit
{
    public partial class frmMain : Form
    {
        frmLoginUI frmLogin = new frmLoginUI();
        public int counter = 0;
        public frmMain()
        {
            InitializeComponent();
            this.BackColor = accColor();
        }
        Color accColor()
        {
            Color a = Color.FromArgb(0,0,0,0);
            try
            {
                var accentColorValue = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "AccentColor", null);

                if (accentColorValue != null)
                {
                    int colorValue = (int)accentColorValue;
                    // Color value is in BGR format, so we need to convert it to RGB
                    Color accentColor = Color.FromArgb(
                        (colorValue >> 24) & 0xff, // Alpha
                        (colorValue >> 0) & 0xff,  // Blue
                        (colorValue >> 8) & 0xff,  // Green
                        (colorValue >> 16) & 0xff  // Red
                    );

                    a = accentColor;
                }
            }
            catch (Exception _3)
            {
                //MessageBox.Show($"Error getting accent color: {ex.Message}");
                a = Color.FromArgb(255,255,255,255);
            }
            return a;
        }
        static Color LightenColor(Color color, int amount)
        {
            // Ограничить значения в пределах 0-255
            int r = Math.Min(color.R + amount, 255);
            int g = Math.Min(color.G + amount, 255);
            int b = Math.Min(color.B + amount, 255);

            return Color.FromArgb(color.A, r, g, b);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.isLoggedIn == true)
            {
                metroTile1.BackColor = LightenColor(accColor(), 30);
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                frmLogin.Close();
            }
            //counter++;
        }
    }
}
