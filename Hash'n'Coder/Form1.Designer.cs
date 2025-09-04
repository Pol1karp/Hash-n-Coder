namespace Hash_n_Coder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NavigationPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HashingButton = new Guna.UI2.WinForms.Guna2Button();
            this.AESButton = new Guna.UI2.WinForms.Guna2Button();
            this.EncodingButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.InputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NavigationPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.NavigationPanel.Controls.Add(this.guna2HtmlLabel1);
            this.NavigationPanel.Controls.Add(this.HashingButton);
            this.NavigationPanel.Controls.Add(this.AESButton);
            this.NavigationPanel.Controls.Add(this.EncodingButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(884, 55);
            this.NavigationPanel.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(773, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 22);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Hash\'n\'Coder";
            // 
            // HashingButton
            // 
            this.HashingButton.Animated = true;
            this.HashingButton.AutoRoundedCorners = true;
            this.HashingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HashingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HashingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HashingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HashingButton.FillColor = System.Drawing.SystemColors.Highlight;
            this.HashingButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HashingButton.ForeColor = System.Drawing.Color.White;
            this.HashingButton.Location = new System.Drawing.Point(384, 3);
            this.HashingButton.Name = "HashingButton";
            this.HashingButton.Size = new System.Drawing.Size(180, 45);
            this.HashingButton.TabIndex = 2;
            this.HashingButton.Text = "Hashing";
            this.HashingButton.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // AESButton
            // 
            this.AESButton.Animated = true;
            this.AESButton.AutoRoundedCorners = true;
            this.AESButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AESButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AESButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AESButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AESButton.FillColor = System.Drawing.SystemColors.Highlight;
            this.AESButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AESButton.ForeColor = System.Drawing.Color.White;
            this.AESButton.Location = new System.Drawing.Point(198, 3);
            this.AESButton.Name = "AESButton";
            this.AESButton.Size = new System.Drawing.Size(180, 45);
            this.AESButton.TabIndex = 1;
            this.AESButton.Text = "AES";
            this.AESButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // EncodingButton
            // 
            this.EncodingButton.Animated = true;
            this.EncodingButton.AutoRoundedCorners = true;
            this.EncodingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EncodingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EncodingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EncodingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EncodingButton.FillColor = System.Drawing.SystemColors.Highlight;
            this.EncodingButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EncodingButton.ForeColor = System.Drawing.Color.White;
            this.EncodingButton.Location = new System.Drawing.Point(12, 3);
            this.EncodingButton.Name = "EncodingButton";
            this.EncodingButton.Size = new System.Drawing.Size(180, 45);
            this.EncodingButton.TabIndex = 0;
            this.EncodingButton.Text = "Encoding";
            this.EncodingButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.InputTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 55);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(884, 636);
            this.MainPanel.TabIndex = 2;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Animated = true;
            this.InputTextBox.BackColor = System.Drawing.Color.Transparent;
            this.InputTextBox.BorderColor = System.Drawing.Color.Silver;
            this.InputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTextBox.DefaultText = resources.GetString("InputTextBox.DefaultText");
            this.InputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InputTextBox.ForeColor = System.Drawing.Color.Black;
            this.InputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PlaceholderForeColor = System.Drawing.SystemColors.Info;
            this.InputTextBox.PlaceholderText = "";
            this.InputTextBox.ReadOnly = true;
            this.InputTextBox.SelectedText = "";
            this.InputTextBox.Size = new System.Drawing.Size(884, 636);
            this.InputTextBox.TabIndex = 18;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 691);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash\'n\'Coder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel NavigationPanel;
        private Guna.UI2.WinForms.Guna2Button HashingButton;
        private Guna.UI2.WinForms.Guna2Button AESButton;
        private Guna.UI2.WinForms.Guna2Button EncodingButton;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox InputTextBox;
    }
}

