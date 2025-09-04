namespace Hash_n_Coder
{
    partial class MyEncoding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyEncoding));
            this.AlgoritmBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TitelLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CodeDecodeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AlChouseLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CodeDecodelabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.OutputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.InputTextLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.OutputLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PasteButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.CopyButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // AlgoritmBox
            // 
            this.AlgoritmBox.AutoRoundedCorners = true;
            this.AlgoritmBox.BackColor = System.Drawing.Color.Transparent;
            this.AlgoritmBox.BorderRadius = 17;
            this.AlgoritmBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AlgoritmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlgoritmBox.FillColor = System.Drawing.SystemColors.HotTrack;
            this.AlgoritmBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AlgoritmBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AlgoritmBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AlgoritmBox.ForeColor = System.Drawing.Color.White;
            this.AlgoritmBox.ItemHeight = 30;
            this.AlgoritmBox.Items.AddRange(new object[] {
            "Base64",
            "UrlEncode",
            "HtmlEncode",
            "UnescapeEncode"});
            this.AlgoritmBox.Location = new System.Drawing.Point(30, 85);
            this.AlgoritmBox.Name = "AlgoritmBox";
            this.AlgoritmBox.Size = new System.Drawing.Size(256, 36);
            this.AlgoritmBox.StartIndex = 0;
            this.AlgoritmBox.TabIndex = 0;
            // 
            // TitelLabel
            // 
            this.TitelLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelLabel.Location = new System.Drawing.Point(383, 3);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(93, 27);
            this.TitelLabel.TabIndex = 1;
            this.TitelLabel.Text = "Encoding";
            // 
            // CodeDecodeBox
            // 
            this.CodeDecodeBox.AutoRoundedCorners = true;
            this.CodeDecodeBox.BackColor = System.Drawing.Color.Transparent;
            this.CodeDecodeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CodeDecodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodeDecodeBox.FillColor = System.Drawing.SystemColors.HotTrack;
            this.CodeDecodeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeDecodeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CodeDecodeBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CodeDecodeBox.ForeColor = System.Drawing.Color.White;
            this.CodeDecodeBox.ItemHeight = 30;
            this.CodeDecodeBox.Items.AddRange(new object[] {
            "Encode",
            "Decode"});
            this.CodeDecodeBox.Location = new System.Drawing.Point(595, 85);
            this.CodeDecodeBox.Name = "CodeDecodeBox";
            this.CodeDecodeBox.Size = new System.Drawing.Size(256, 36);
            this.CodeDecodeBox.StartIndex = 0;
            this.CodeDecodeBox.TabIndex = 2;
            // 
            // AlChouseLabel
            // 
            this.AlChouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.AlChouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlChouseLabel.Location = new System.Drawing.Point(30, 57);
            this.AlChouseLabel.Name = "AlChouseLabel";
            this.AlChouseLabel.Size = new System.Drawing.Size(246, 22);
            this.AlChouseLabel.TabIndex = 3;
            this.AlChouseLabel.Text = "Выбор алгоритма кодирования:";
            // 
            // CodeDecodelabel
            // 
            this.CodeDecodelabel.BackColor = System.Drawing.Color.Transparent;
            this.CodeDecodelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeDecodelabel.Location = new System.Drawing.Point(595, 57);
            this.CodeDecodelabel.Name = "CodeDecodelabel";
            this.CodeDecodelabel.Size = new System.Drawing.Size(247, 22);
            this.CodeDecodelabel.TabIndex = 4;
            this.CodeDecodelabel.Text = "Кодировать или декодировать:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Animated = true;
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
            this.InputTextBox.Location = new System.Drawing.Point(30, 181);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.InputTextBox.PlaceholderText = "";
            this.InputTextBox.SelectedText = "";
            this.InputTextBox.Size = new System.Drawing.Size(358, 360);
            this.InputTextBox.TabIndex = 5;
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
            this.OutputTextBox.Location = new System.Drawing.Point(493, 181);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.OutputTextBox.PlaceholderText = "";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.Size = new System.Drawing.Size(358, 360);
            this.OutputTextBox.TabIndex = 6;
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextLabel.Location = new System.Drawing.Point(30, 152);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(121, 22);
            this.InputTextLabel.TabIndex = 7;
            this.InputTextLabel.Text = "Введите текст:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(493, 152);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(87, 22);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.Text = "Результат:";
            // 
            // PasteButton
            // 
            this.PasteButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.PasteButton.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.PasteButton.ImageRotate = 0F;
            this.PasteButton.ImageSize = new System.Drawing.Size(24, 24);
            this.PasteButton.Location = new System.Drawing.Point(338, 141);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.PasteButton.Size = new System.Drawing.Size(50, 33);
            this.PasteButton.TabIndex = 9;
            this.PasteButton.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CopyButton.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.CopyButton.ImageRotate = 0F;
            this.CopyButton.ImageSize = new System.Drawing.Size(24, 24);
            this.CopyButton.Location = new System.Drawing.Point(801, 141);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.CopyButton.Size = new System.Drawing.Size(50, 33);
            this.CopyButton.TabIndex = 10;
            this.CopyButton.Click += new System.EventHandler(this.guna2ImageButton2_Click);
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
            this.StartButton.Location = new System.Drawing.Point(300, 578);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(280, 45);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Encode\\Decode";
            this.StartButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MyEncoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputTextLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.CodeDecodelabel);
            this.Controls.Add(this.AlChouseLabel);
            this.Controls.Add(this.CodeDecodeBox);
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.AlgoritmBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MyEncoding";
            this.Size = new System.Drawing.Size(884, 636);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox AlgoritmBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel TitelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox CodeDecodeBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel AlChouseLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel CodeDecodelabel;
        private Guna.UI2.WinForms.Guna2TextBox InputTextBox;
        private Guna.UI2.WinForms.Guna2TextBox OutputTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel InputTextLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel OutputLabel;
        private Guna.UI2.WinForms.Guna2ImageButton PasteButton;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton CopyButton;
        private Guna.UI2.WinForms.Guna2Button StartButton;
    }
}
