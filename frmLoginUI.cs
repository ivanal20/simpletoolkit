using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace simpletoolkit
{
    public partial class frmLoginUI : Form
    {
        public frmLoginUI()
        {
            InitializeComponent();
            this.BackColor = accColor();
            string wallpaperPath = GetDesktopWallpaperPath();
            if (!string.IsNullOrEmpty(wallpaperPath))
            {
                this.BackgroundImage = Image.FromFile(wallpaperPath);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show("Не удалось найти изображение рабочего стола");
                //this.BackgroundImage = GetDesktopWallpaper();
            }
        }
        Color accColor()
        {
            Color a = Color.FromArgb(0, 0, 0, 0);
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
            catch (Exception _1)
            {
                //MessageBox.Show($"Error getting accent color: {ex.Message}");
                a = Color.FromArgb(255, 255, 255, 255);
            }
            return a;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, StringBuilder lpvParam, int fuWinIni);
        private const int SPI_GETDESKWALLPAPER = 0x73;
        private static string GetDesktopWallpaperPath()
        {
            /*Image img;
            string sourceFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets");
            if (!Directory.Exists(sourceFolder))
                throw new DirectoryNotFoundException("Папка с изображениями экрана блокировки не найдена.");
            var files = Directory.GetFiles(sourceFolder).OrderByDescending(File.GetLastWriteTime);
            return img;*/
            StringBuilder wallpaperPath = new StringBuilder(260);
            SystemParametersInfo(SPI_GETDESKWALLPAPER, wallpaperPath.Capacity, wallpaperPath, 0);
            return wallpaperPath.ToString();
        }

        private void frmLoginUI_Load(object sender, EventArgs e)
        {
            scrLogin scrLogin = new scrLogin();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(scrLogin);
            scrLogin.Dock = DockStyle.Fill;
            scrLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void btnLoginChangeScr_Click(object sender, EventArgs e)
        {
            scrLogin scrLogin = new scrLogin();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(scrLogin);
        }
    }
}
