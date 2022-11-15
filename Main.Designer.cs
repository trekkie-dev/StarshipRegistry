namespace StarshipRegistryGUI
    {
    partial class MainForm
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.headingLabel = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.StarshipButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.stardateLabel = new System.Windows.Forms.Label();
            this.StationButton = new System.Windows.Forms.Button();
            this.WatchButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.WatchOnPPlus = new System.Windows.Forms.LinkLabel();
            this.PplusLogo = new System.Windows.Forms.PictureBox();
            this.RegisteredShips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PplusLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Antonio", 31.92453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.headingLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headingLabel.Location = new System.Drawing.Point(240, 172);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(1017, 82);
            this.headingLabel.TabIndex = 5;
            this.headingLabel.Text = "WELCOME";
            this.headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputText.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(191)))), ((int)(((byte)(189)))));
            this.inputText.Location = new System.Drawing.Point(419, 259);
            this.inputText.MaxLength = 60;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(838, 28);
            this.inputText.TabIndex = 6;
            this.inputText.Enter += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.AppTitleLabel.Font = new System.Drawing.Font("Antonio Thin", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.AppTitleLabel.Location = new System.Drawing.Point(230, 62);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(1027, 110);
            this.AppTitleLabel.TabIndex = 19;
            this.AppTitleLabel.Text = "LCARS";
            this.AppTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectionLabel
            // 
            this.selectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectionLabel.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.selectionLabel.Location = new System.Drawing.Point(246, 259);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(167, 30);
            this.selectionLabel.TabIndex = 20;
            this.selectionLabel.Text = "SEARCH PARAMETERS:";
            this.selectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StarshipButton
            // 
            this.StarshipButton.BackColor = System.Drawing.Color.Transparent;
            this.StarshipButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.starRegButton;
            this.StarshipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StarshipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StarshipButton.FlatAppearance.BorderSize = 0;
            this.StarshipButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StarshipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StarshipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StarshipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarshipButton.Location = new System.Drawing.Point(1282, 82);
            this.StarshipButton.Name = "StarshipButton";
            this.StarshipButton.Size = new System.Drawing.Size(200, 54);
            this.StarshipButton.TabIndex = 22;
            this.StarshipButton.UseVisualStyleBackColor = false;
            this.StarshipButton.Click += new System.EventHandler(this.AccessBtn_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.exitButton;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(1282, 274);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 54);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.infoTextBox.Font = new System.Drawing.Font("Antonio Light", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.infoTextBox.Location = new System.Drawing.Point(243, 812);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(1113, 31);
            this.infoTextBox.TabIndex = 30;
            this.infoTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.ConfirmButton;
            this.ConfirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Location = new System.Drawing.Point(44, 271);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(170, 54);
            this.ConfirmButton.TabIndex = 31;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.ClearButton;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(44, 335);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(170, 54);
            this.ClearButton.TabIndex = 33;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // stardateLabel
            // 
            this.stardateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stardateLabel.Font = new System.Drawing.Font("Antonio SemiBold", 27.84906F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stardateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(116)))), ((int)(((byte)(132)))));
            this.stardateLabel.Location = new System.Drawing.Point(45, 426);
            this.stardateLabel.Name = "stardateLabel";
            this.stardateLabel.Size = new System.Drawing.Size(187, 62);
            this.stardateLabel.TabIndex = 37;
            this.stardateLabel.Text = "87564.1";
            this.stardateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StationButton
            // 
            this.StationButton.BackColor = System.Drawing.Color.Transparent;
            this.StationButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.statRegButton;
            this.StationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StationButton.FlatAppearance.BorderSize = 0;
            this.StationButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StationButton.Location = new System.Drawing.Point(1282, 146);
            this.StationButton.Name = "StationButton";
            this.StationButton.Size = new System.Drawing.Size(200, 54);
            this.StationButton.TabIndex = 38;
            this.StationButton.UseVisualStyleBackColor = false;
            this.StationButton.Click += new System.EventHandler(this.StationRegButton_Click);
            // 
            // WatchButton
            // 
            this.WatchButton.BackColor = System.Drawing.Color.Transparent;
            this.WatchButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.watchButton;
            this.WatchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WatchButton.FlatAppearance.BorderSize = 0;
            this.WatchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.WatchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WatchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WatchButton.Location = new System.Drawing.Point(1282, 210);
            this.WatchButton.Name = "WatchButton";
            this.WatchButton.Size = new System.Drawing.Size(200, 54);
            this.WatchButton.TabIndex = 39;
            this.WatchButton.UseVisualStyleBackColor = false;
            this.WatchButton.Click += new System.EventHandler(this.WatchButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.outputLabel.Location = new System.Drawing.Point(246, 308);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(992, 491);
            this.outputLabel.TabIndex = 40;
            this.outputLabel.Text = " ";
            // 
            // WatchOnPPlus
            // 
            this.WatchOnPPlus.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.WatchOnPPlus.AutoSize = true;
            this.WatchOnPPlus.BackColor = System.Drawing.Color.Transparent;
            this.WatchOnPPlus.Font = new System.Drawing.Font("Antonio", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WatchOnPPlus.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.WatchOnPPlus.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.WatchOnPPlus.Location = new System.Drawing.Point(697, 689);
            this.WatchOnPPlus.Name = "WatchOnPPlus";
            this.WatchOnPPlus.Size = new System.Drawing.Size(227, 37);
            this.WatchOnPPlus.TabIndex = 42;
            this.WatchOnPPlus.TabStop = true;
            this.WatchOnPPlus.Text = "WATCH ON PARAMOUNT +";
            this.WatchOnPPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WatchOnPPlus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WatchOnPPlus_LinkClicked);
            // 
            // PplusLogo
            // 
            this.PplusLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PplusLogo.Image = global::StarshipRegistryGUI.Properties.Resources.Paramount__logo;
            this.PplusLogo.Location = new System.Drawing.Point(639, 495);
            this.PplusLogo.Name = "PplusLogo";
            this.PplusLogo.Size = new System.Drawing.Size(342, 191);
            this.PplusLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PplusLogo.TabIndex = 43;
            this.PplusLogo.TabStop = false;
            this.PplusLogo.Click += new System.EventHandler(this.PplusLogo_Click);
            // 
            // RegisteredShips
            // 
            this.RegisteredShips.BackColor = System.Drawing.Color.Transparent;
            this.RegisteredShips.Font = new System.Drawing.Font("Antonio", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisteredShips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.RegisteredShips.Location = new System.Drawing.Point(1245, 359);
            this.RegisteredShips.Name = "RegisteredShips";
            this.RegisteredShips.Size = new System.Drawing.Size(237, 460);
            this.RegisteredShips.TabIndex = 44;
            this.RegisteredShips.Text = " ";
            this.RegisteredShips.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AcceptButton = this.ConfirmButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.lcarsPicardEra__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.RegisteredShips);
            this.Controls.Add(this.PplusLogo);
            this.Controls.Add(this.WatchOnPPlus);
            this.Controls.Add(this.WatchButton);
            this.Controls.Add(this.StationButton);
            this.Controls.Add(this.stardateLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StarshipButton);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.AppTitleLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.selectionLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCARS DATABASE ACCESS    ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PplusLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label headingLabel;
        private TextBox inputText;
        private Label AppTitleLabel;
        private Label selectionLabel;
        private Button StarshipButton;
        private Button ExitButton;
        private Label infoTextBox;
        private Button ConfirmButton;
        private Button ClearButton;
        private Label stardateLabel;
        private Button StationButton;
        private Button WatchButton;
        private Label outputLabel;
        private LinkLabel WatchOnPPlus;
        private PictureBox PplusLogo;
        private Label RegisteredShips;
        }
    }