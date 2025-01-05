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
    public partial class scrRegister : UserControl
    {
        // Конфигурация
        private readonly string GitHubApiUrl = "https://api.github.com/repos/ivanal20/pocket-m-i-mc/contents/auth_edu/users.txt";
        private readonly string GitHubToken = Encoding.UTF8.GetString(Convert.FromBase64String("Z2l0aHViX3BhdF8xMUE0R1BBR1kwSWFnVjB5ZmpLdzlmX0dwUkZjWDR4RHNmMUszMUJmTTJraERXdXo1ZExCTld5NlVBSEpWVUh4OWJDV04zSU9HM3pLbGhldEM0")); // Токен
        frmLoginUI frmLoginUI;
        scrLoginSuccess scrLoginSuccess;
        public scrRegister()
        {
            InitializeComponent();
        }

        private void btnExitR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string repeat_password = txtRepeatPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Введите имя пользователя и пароль.";
                return;
            }

            if (!password.Equals(repeat_password)) 
            {
                lblMessage.Text = "Пароли не совпадают";
                return;
            }

            try
            {
                // Получаем текущее содержимое файла
                string fileContent = await GetFileContent();

                // Проверка, есть ли уже пользователь
                if (fileContent.Contains($"{username} "))
                {
                    lblMessage.Text = "Пользователь уже существует.";
                    return;
                }

                // Формируем новую строку
                string newContent = fileContent + $"\n{username} {password}";

                // Отправляем обновление файла
                await UpdateFileContent(newContent);
                lblMessage.Text = "Регистрация успешна!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Ошибка: {ex.Message}";
            }
        }

        // Метод обновления содержимого файла на GitHub
        private async Task UpdateFileContent(string newContent)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# WinForms App");
            client.DefaultRequestHeaders.Add("Authorization", $"token {GitHubToken}");

            // Получаем SHA текущего файла
            var response = await client.GetAsync(GitHubApiUrl);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonDoc = JsonDocument.Parse(jsonResponse);
            string sha = jsonDoc.RootElement.GetProperty("sha").GetString();

            // Кодируем новое содержимое в Base64
            string newContentBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(newContent));

            // Формируем JSON для отправки
            var json = new
            {
                message = "Добавление нового пользователя",
                content = newContentBase64,
                sha
            };

            var content = new StringContent(JsonSerializer.Serialize(json), Encoding.UTF8, "application/json");

            // Отправляем PUT-запрос
            var putResponse = await client.PutAsync(GitHubApiUrl, content);
            putResponse.EnsureSuccessStatusCode();
        }
        private async Task<string> GetFileContent()
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
