namespace Hash_n_Coder
{
    partial class MyHashing
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHashing));
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.CopyButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PasteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.OutputLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InputLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Animated = true;
            this.StartButton.AutoRoundedCorners = true;
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.FillColor = System.Drawing.SystemColors.HotTrack;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(302, 583);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 45);
            this.StartButton.TabIndex = 23;
            this.StartButton.Text = "Получить хеши";
            this.StartButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CopyButton.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.CopyButton.ImageRotate = 0F;
            this.CopyButton.ImageSize = new System.Drawing.Size(24, 24);
            this.CopyButton.Location = new System.Drawing.Point(803, 45);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.CopyButton.Size = new System.Drawing.Size(50, 33);
            this.CopyButton.TabIndex = 22;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PasteButton.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PasteButton.ImageRotate = 0F;
            this.PasteButton.ImageSize = new System.Drawing.Size(24, 24);
            this.PasteButton.Location = new System.Drawing.Point(340, 45);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.PasteButton.Size = new System.Drawing.Size(50, 33);
            this.PasteButton.TabIndex = 21;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(495, 56);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(87, 22);
            this.OutputLabel.TabIndex = 20;
            this.OutputLabel.Text = "Результат:";
            // 
            // InputLabel
            // 
            this.InputLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.Location = new System.Drawing.Point(32, 56);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(121, 22);
            this.InputLabel.TabIndex = 19;
            this.InputLabel.Text = "Введите текст:";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Animated = true;
            this.OutputTextBox.BorderColor = System.Drawing.Color.Silver;
            this.OutputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputTextBox.DefaultText = "";
            this.OutputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OutputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OutputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OutputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OutputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OutputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OutputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OutputTextBox.Location = new System.Drawing.Point(495, 85);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.Size = new System.Drawing.Size(358, 461);
            this.OutputTextBox.TabIndex = 18;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Animated = true;
            this.InputTextBox.BackColor = System.Drawing.Color.Transparent;
            this.InputTextBox.BorderColor = System.Drawing.Color.Silver;
            this.InputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTextBox.DefaultText = "";
            this.InputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputTextBox.Location = new System.Drawing.Point(32, 85);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.InputTextBox.PlaceholderText = "";
            this.InputTextBox.SelectedText = "";
            this.InputTextBox.Size = new System.Drawing.Size(358, 461);
            this.InputTextBox.TabIndex = 17;
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(385, 8);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(82, 27);
            this.TitelLabel.TabIndex = 13;
            this.TitelLabel.Text = "Hashing";
            // 
            // MyHashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.TitelLabel);
            this.Name = "MyHashing";
            this.Size = new System.Drawing.Size(884, 636);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2ImageButton CopyButton;
        private Guna.UI2.WinForms.Guna2ImageButton PasteButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel OutputLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel InputLabel;
        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2TextBox InputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
    }
}
