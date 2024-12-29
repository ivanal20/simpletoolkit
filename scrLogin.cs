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
        private readonly string GitHubToken = "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"; // Токен
        frmLoginUI frmLoginUI;
        scrLoginSuccess scrLoginSuccess;
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
                    frmLoginUI.pnlContent.Controls.Clear();
                    frmLoginUI.pnlContent.Controls.Add(scrLoginSuccess);
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
