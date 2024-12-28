namespace simpletoolkit
{
    partial class frmLoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginUI));
            this.pnlBlur = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnLoginChangeScr = new System.Windows.Forms.Button();
            this.btnRegisterChangeScr = new System.Windows.Forms.Button();
            this.pnlBlur.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBlur
            // 
            this.pnlBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBlur.Controls.Add(this.pnlContent);
            this.pnlBlur.Controls.Add(this.btnLoginChangeScr);
            this.pnlBlur.Controls.Add(this.btnRegisterChangeScr);
            this.pnlBlur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBlur.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlBlur.Location = new System.Drawing.Point(0, 0);
            this.pnlBlur.Name = "pnlBlur";
            this.pnlBlur.Size = new System.Drawing.Size(897, 526);
            this.pnlBlur.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlContent.Location = new System.Drawing.Point(162, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(735, 526);
            this.pnlContent.TabIndex = 5;
            // 
            // btnLoginChangeScr
            // 
            this.btnLoginChangeScr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginChangeScr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoginChangeScr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoginChangeScr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoginChangeScr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLoginChangeScr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginChangeScr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginChangeScr.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoginChangeScr.Image = global::simpletoolkit.Properties.Resources.user;
            this.btnLoginChangeScr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoginChangeScr.Location = new System.Drawing.Point(0, 415);
            this.btnLoginChangeScr.Name = "btnLoginChangeScr";
            this.btnLoginChangeScr.Size = new System.Drawing.Size(162, 56);
            this.btnLoginChangeScr.TabIndex = 4;
            this.btnLoginChangeScr.Text = "Вход";
            this.btnLoginChangeScr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoginChangeScr.UseVisualStyleBackColor = false;
            this.btnLoginChangeScr.Click += new System.EventHandler(this.btnLoginChangeScr_Click);
            // 
            // btnRegisterChangeScr
            // 
            this.btnRegisterChangeScr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegisterChangeScr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegisterChangeScr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegisterChangeScr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegisterChangeScr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegisterChangeScr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterChangeScr.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterChangeScr.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRegisterChangeScr.Image = global::simpletoolkit.Properties.Resources.adduser;
            this.btnRegisterChangeScr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterChangeScr.Location = new System.Drawing.Point(0, 470);
            this.btnRegisterChangeScr.Name = "btnRegisterChangeScr";
            this.btnRegisterChangeScr.Size = new System.Drawing.Size(162, 56);
            this.btnRegisterChangeScr.TabIndex = 3;
            this.btnRegisterChangeScr.Text = "Регистрация";
            this.btnRegisterChangeScr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegisterChangeScr.UseVisualStyleBackColor = false;
            // 
            // frmLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(897, 526);
            this.Controls.Add(this.pnlBlur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoginUI_Load);
            this.pnlBlur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBlur;
        private System.Windows.Forms.Button btnLoginChangeScr;
        private System.Windows.Forms.Button btnRegisterChangeScr;
        private System.Windows.Forms.Panel pnlContent;
        //private CustomMetroTextBox customMetroTextBox1;
    }
}