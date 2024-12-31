using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpletoolkit
{
    public partial class scrLogin : UserControl
    {
        // Конфигурация
        private readonly string GitHubApiUrl = "https://api.github.com/repos/ivanal20/pocket-m-i-mc/contents/auth_edu/users.txt";
        private readonly string GitHubToken = Encoding.UTF8.GetString(Convert.FromBase64String("Z2l0aHViX3BhdF8xMUE0R1BBR1kwQ09GWWxLeEF4Wnl0XzJ1bjlyWmhLS21HQ24yQ0xOUDlocVRQNmNHd3dxSkc2TDlmUnZydEhBZWUzQUZCWlZYRTVVRld3S3Ns")); // Токен
        frmLoginUI frmLoginUI = new frmLoginUI();
        frmMain frmMain = new frmMain();
        //var settings = new PublicSettings();
        //private static bool _isLoggedIn = false;
        //public static bool IsLoggedIn
        //{
        //    get { return _isLoggedIn; }
        //    //set { _isLoggedIn = value; }
        //}
        //frmLoginUi.pnlContent pnlContent;
        scrLoginSuccess scrLoginSuccess = new scrLoginSuccess();
        public scrLogin()
        {
            InitializeComponent();
        }

        private void btnExitL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Введите имя пользователя и пароль.";
                return;
            }

            try
            {
                // Получаем текущее содержимое файла
                string fileContent = await GetFileContent();

                // Проверяем данные пользователя
                if (fileContent.Contains($"{username} {password}"))
                {
                    /*frmLoginUI.pnlContent.Controls.Clear();
                    frmLoginUI.pnlContent.Controls.Add(scrLoginSuccess);
                    scrLoginSuccess.Dock = DockStyle.Fill;
                    scrLoginSuccess.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;*/
                    //_isLoggedIn = true;
                    Properties.Settings.Default.isLoggedIn = true;
                    Properties.Settings.Default.username = username;
                    Properties.Settings.Default.password = password;
                    Properties.Settings.Default.Save();
                    frmLoginUI.Close();
                    frmMain.Show();
                    //lblMessage.Text = "Кнопка входа была нажата";
                }
                else
                {
                    lblMessage.Text = "Неверные имя пользователя или пароль.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Ошибка: {ex.Message}";
            }
        }

            public async Task<String> GetFileContent()
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "C# WinForms App");
                client.DefaultRequestHeaders.Add("Authorization", $"token {GitHubToken}");

                var response = await client.GetAsync(GitHubApiUrl);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var jsonDoc = JsonDocument.Parse(jsonResponse);
                string contentBase64 = jsonDoc.RootElement.GetProperty("content").GetString();

                // Декодируем содержимое из Base64
                byte[] contentBytes = Convert.FromBase64String(contentBase64);
                return Encoding.UTF8.GetString(contentBytes);
            }

        
    }
    }
