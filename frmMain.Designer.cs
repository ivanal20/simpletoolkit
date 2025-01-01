namespace simpletoolkit
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.resizedImgList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlProfileMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProfileMenu = new System.Windows.Forms.Button();
            this.wingetGuiTile = new MetroFramework.Controls.MetroTile();
            this.pnlProfileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главное меню";
            // 
            // resizedImgList1
            // 
            this.resizedImgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("resizedImgList1.ImageStream")));
            this.resizedImgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.resizedImgList1.Images.SetKeyName(0, "DefaultAccountTile.png");
            this.resizedImgList1.Images.SetKeyName(1, "Logout.png");
            this.resizedImgList1.Images.SetKeyName(2, "Settings.png");
            // 
            // pnlProfileMenu
            // 
            this.pnlProfileMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlProfileMenu.Controls.Add(this.button3);
            this.pnlProfileMenu.Controls.Add(this.button2);
            this.pnlProfileMenu.Location = new System.Drawing.Point(687, 83);
            this.pnlProfileMenu.Name = "pnlProfileMenu";
            this.pnlProfileMenu.Size = new System.Drawing.Size(106, 80);
            this.pnlProfileMenu.TabIndex = 3;
            this.pnlProfileMenu.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "Logout.png";
            this.button3.ImageList = this.resizedImgList1;
            this.button3.Location = new System.Drawing.Point(0, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "username";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "Settings.png";
            this.button2.ImageList = this.resizedImgList1;
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Настройки";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnProfileMenu
            // 
            this.btnProfileMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnProfileMenu.FlatAppearance.BorderSize = 0;
            this.btnProfileMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileMenu.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfileMenu.ForeColor = System.Drawing.Color.White;
            this.btnProfileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfileMenu.ImageKey = "DefaultAccountTile.png";
            this.btnProfileMenu.ImageList = this.resizedImgList1;
            this.btnProfileMenu.Location = new System.Drawing.Point(687, 46);
            this.btnProfileMenu.Name = "btnProfileMenu";
            this.btnProfileMenu.Size = new System.Drawing.Size(106, 37);
            this.btnProfileMenu.TabIndex = 2;
            this.btnProfileMenu.Text = "username";
            this.btnProfileMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfileMenu.UseVisualStyleBackColor = false;
            this.btnProfileMenu.Click += new System.EventHandler(this.btnProfileMenu_Click);
            // 
            // wingetGuiTile
            // 
            this.wingetGuiTile.ActiveControl = null;
            this.wingetGuiTile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.wingetGuiTile.Location = new System.Drawing.Point(85, 146);
            this.wingetGuiTile.Name = "wingetGuiTile";
            this.wingetGuiTile.Size = new System.Drawing.Size(192, 96);
            this.wingetGuiTile.TabIndex = 0;
            this.wingetGuiTile.Text = "Winget GUI";
            this.wingetGuiTile.TileImage = global::simpletoolkit.Properties.Resources.wingetgui;
            this.wingetGuiTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wingetGuiTile.UseCustomBackColor = true;
            this.wingetGuiTile.UseSelectable = true;
            this.wingetGuiTile.UseTileImage = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(904, 528);
            this.Controls.Add(this.pnlProfileMenu);
            this.Controls.Add(this.btnProfileMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wingetGuiTile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlProfileMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile wingetGuiTile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfileMenu;
        private System.Windows.Forms.ImageList resizedImgList1;
        private System.Windows.Forms.Panel pnlProfileMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

