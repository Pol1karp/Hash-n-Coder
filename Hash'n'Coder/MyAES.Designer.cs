namespace Hash_n_Coder
{
    partial class MyAES
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAES));
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.CopyButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PasteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.OutputLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextInputLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShifrLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AlChouseLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShifrBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AlgoritmBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.KeyBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.KeyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.KeyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputKeyLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GenKeyButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Animated = true;
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.FillColor = System.Drawing.Color.DimGray;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(302, 583);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 45);
            this.StartButton.TabIndex = 23;
            this.StartButton.Text = "Encrypt\\Decrypt";
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
            this.CopyButton.Location = new System.Drawing.Point(803, 376);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.CopyButton.Size = new System.Drawing.Size(50, 33);
            this.CopyButton.TabIndex = 22;
            this.CopyButton.Click += new System.EventHandler(this.guna2ImageButton2_Click_1);
            // 
            // PasteButton
            // 
            this.PasteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PasteButton.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PasteButton.ImageRotate = 0F;
            this.PasteButton.ImageSize = new System.Drawing.Size(24, 24);
            this.PasteButton.Location = new System.Drawing.Point(340, 376);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.PasteButton.Size = new System.Drawing.Size(50, 33);
            this.PasteButton.TabIndex = 21;
            this.PasteButton.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(495, 387);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(87, 22);
            this.OutputLabel.TabIndex = 20;
            this.OutputLabel.Text = "Результат:";
            // 
            // TextInputLabel
            // 
            this.TextInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInputLabel.Location = new System.Drawing.Point(32, 387);
            this.TextInputLabel.Name = "TextInputLabel";
            this.TextInputLabel.Size = new System.Drawing.Size(121, 22);
            this.TextInputLabel.TabIndex = 19;
            this.TextInputLabel.Text = "Введите текст:";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Animated = true;
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
            this.OutputTextBox.Location = new System.Drawing.Point(495, 416);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.Size = new System.Drawing.Size(358, 146);
            this.OutputTextBox.TabIndex = 18;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Animated = true;
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
            this.InputTextBox.Location = new System.Drawing.Point(32, 416);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PlaceholderText = "";
            this.InputTextBox.SelectedText = "";
            this.InputTextBox.Size = new System.Drawing.Size(358, 146);
            this.InputTextBox.TabIndex = 17;
            // 
            // ShifrLabel
            // 
            this.ShifrLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShifrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShifrLabel.Location = new System.Drawing.Point(597, 62);
            this.ShifrLabel.Name = "ShifrLabel";
            this.ShifrLabel.Size = new System.Drawing.Size(245, 22);
            this.ShifrLabel.TabIndex = 16;
            this.ShifrLabel.Text = "Шифровать или дешифровать:";
            // 
            // AlChouseLabel
            // 
            this.AlChouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlChouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlChouseLabel.Location = new System.Drawing.Point(32, 62);
            this.AlChouseLabel.Name = "AlChouseLabel";
            this.AlChouseLabel.Size = new System.Drawing.Size(246, 22);
            this.AlChouseLabel.TabIndex = 15;
            this.AlChouseLabel.Text = "Выбор алгоритма шифрования:";
            // 
            // ShifrBox
            // 
            this.ShifrBox.BackColor = System.Drawing.Color.Transparent;
            this.ShifrBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ShifrBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShifrBox.FillColor = System.Drawing.Color.DimGray;
            this.ShifrBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShifrBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShifrBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShifrBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShifrBox.ItemHeight = 30;
            this.ShifrBox.Items.AddRange(new object[] {
            "Шифровать",
            "Дешифровать"});
            this.ShifrBox.Location = new System.Drawing.Point(597, 90);
            this.ShifrBox.Name = "ShifrBox";
            this.ShifrBox.Size = new System.Drawing.Size(256, 36);
            this.ShifrBox.StartIndex = 0;
            this.ShifrBox.TabIndex = 14;
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(302, 3);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(300, 27);
            this.TitelLabel.TabIndex = 13;
            this.TitelLabel.Text = "Advanced Encryption Standard";
            // 
            // AlgoritmBox
            // 
            this.AlgoritmBox.BackColor = System.Drawing.Color.Transparent;
            this.AlgoritmBox.BorderRadius = 1;
            this.AlgoritmBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AlgoritmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgoritmBox.FillColor = System.Drawing.Color.DimGray;
            this.AlgoritmBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AlgoritmBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AlgoritmBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AlgoritmBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlgoritmBox.ItemHeight = 30;
            this.AlgoritmBox.Items.AddRange(new object[] {
            "AES-ECB",
            "AES-CBC"});
            this.AlgoritmBox.Location = new System.Drawing.Point(32, 90);
            this.AlgoritmBox.Name = "AlgoritmBox";
            this.AlgoritmBox.Size = new System.Drawing.Size(256, 36);
            this.AlgoritmBox.StartIndex = 0;
            this.AlgoritmBox.TabIndex = 12;
            // 
            // KeyBox
            // 
            this.KeyBox.BackColor = System.Drawing.Color.Transparent;
            this.KeyBox.BorderRadius = 1;
            this.KeyBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.KeyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyBox.FillColor = System.Drawing.Color.DimGray;
            this.KeyBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KeyBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KeyBox.ItemHeight = 30;
            this.KeyBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.KeyBox.Location = new System.Drawing.Point(317, 194);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(256, 36);
            this.KeyBox.StartIndex = 0;
            this.KeyBox.TabIndex = 24;
            // 
            // KeyLabel
            // 
            this.KeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(317, 166);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(176, 22);
            this.KeyLabel.TabIndex = 25;
            this.KeyLabel.Text = "Выбор размера ключа:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Animated = true;
            this.KeyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyTextBox.DefaultText = "";
            this.KeyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KeyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KeyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KeyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KeyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KeyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KeyTextBox.Location = new System.Drawing.Point(21, 286);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.PlaceholderText = "";
            this.KeyTextBox.SelectedText = "";
            this.KeyTextBox.Size = new System.Drawing.Size(581, 44);
            this.KeyTextBox.TabIndex = 26;
            // 
            // InputKeyLabel
            // 
            this.InputKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputKeyLabel.Location = new System.Drawing.Point(21, 257);
            this.InputKeyLabel.Name = "InputKeyLabel";
            this.InputKeyLabel.Size = new System.Drawing.Size(117, 22);
            this.InputKeyLabel.TabIndex = 27;
            this.InputKeyLabel.Text = "Введите ключ:";
            // 
            // GenKeyButton
            // 
            this.GenKeyButton.Animated = true;
            this.GenKeyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenKeyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenKeyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenKeyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenKeyButton.FillColor = System.Drawing.Color.DimGray;
            this.GenKeyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenKeyButton.ForeColor = System.Drawing.Color.White;
            this.GenKeyButton.Location = new System.Drawing.Point(609, 286);
            this.GenKeyButton.Name = "GenKeyButton";
            this.GenKeyButton.Size = new System.Drawing.Size(244, 45);
            this.GenKeyButton.TabIndex = 28;
            this.GenKeyButton.Text = "Generate";
            this.GenKeyButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // MyAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenKeyButton);
            this.Controls.Add(this.InputKeyLabel);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.TextInputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ShifrLabel);
            this.Controls.Add(this.AlChouseLabel);
            this.Controls.Add(this.ShifrBox);
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.AlgoritmBox);
            this.Name = "MyAES";
            this.Size = new System.Drawing.Size(884, 636);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2ImageButton CopyButton;
        private Guna.UI2.WinForms.Guna2ImageButton PasteButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel OutputLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel TextInputLabel;
        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2TextBox InputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel ShifrLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel AlChouseLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ShifrBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox AlgoritmBox;
        private Guna.UI2.WinForms.Guna2ComboBox KeyBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel KeyLabel;
        private Guna.UI2.WinForms.Guna2TextBox KeyTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel InputKeyLabel;
        private Guna.UI2.WinForms.Guna2Button GenKeyButton;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}
