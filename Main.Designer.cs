namespace StarshipRegistryGUI
    {
    partial class mainForm
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
            this.starshipRegButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.stardateLabel = new System.Windows.Forms.Label();
            this.stationRegButton = new System.Windows.Forms.Button();
            this.WatchButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.WatchOnPPlus = new System.Windows.Forms.LinkLabel();
            this.PplusLogo = new System.Windows.Forms.PictureBox();
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
            this.inputText.Enter += new System.EventHandler(this.confirmButton_Click);
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
            // starshipRegButton
            // 
            this.starshipRegButton.BackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.starRegButton;
            this.starshipRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.starshipRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starshipRegButton.FlatAppearance.BorderSize = 0;
            this.starshipRegButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.starshipRegButton.Location = new System.Drawing.Point(1281, 100);
            this.starshipRegButton.Name = "starshipRegButton";
            this.starshipRegButton.Size = new System.Drawing.Size(200, 54);
            this.starshipRegButton.TabIndex = 22;
            this.starshipRegButton.UseVisualStyleBackColor = false;
            this.starshipRegButton.Click += new System.EventHandler(this.accessBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.exitButton;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1281, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 54);
            this.exitButton.TabIndex = 25;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitBtn_Click);
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
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.ConfirmButton;
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(44, 271);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(170, 54);
            this.confirmButton.TabIndex = 31;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.ClearButton__1_;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(44, 335);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(170, 54);
            this.clearButton.TabIndex = 33;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
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
            // stationRegButton
            // 
            this.stationRegButton.BackColor = System.Drawing.Color.Transparent;
            this.stationRegButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.statRegButton;
            this.stationRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stationRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stationRegButton.FlatAppearance.BorderSize = 0;
            this.stationRegButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.stationRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stationRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stationRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationRegButton.Location = new System.Drawing.Point(1281, 164);
            this.stationRegButton.Name = "stationRegButton";
            this.stationRegButton.Size = new System.Drawing.Size(200, 54);
            this.stationRegButton.TabIndex = 38;
            this.stationRegButton.UseVisualStyleBackColor = false;
            this.stationRegButton.Click += new System.EventHandler(this.stationRegButton_Click);
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
            this.WatchButton.Location = new System.Drawing.Point(1281, 228);
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
            this.outputLabel.Size = new System.Drawing.Size(1011, 491);
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
            this.WatchOnPPlus.Location = new System.Drawing.Point(631, 699);
            this.WatchOnPPlus.Name = "WatchOnPPlus";
            this.WatchOnPPlus.Size = new System.Drawing.Size(260, 37);
            this.WatchOnPPlus.TabIndex = 42;
            this.WatchOnPPlus.TabStop = true;
            this.WatchOnPPlus.Text = "WATCH ON PARAMOUNT PLUS";
            this.WatchOnPPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WatchOnPPlus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WatchOnPPlus_LinkClicked);
            // 
            // PplusLogo
            // 
            this.PplusLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PplusLogo.Image = global::StarshipRegistryGUI.Properties.Resources.Paramount__logo;
            this.PplusLogo.Location = new System.Drawing.Point(589, 489);
            this.PplusLogo.Name = "PplusLogo";
            this.PplusLogo.Size = new System.Drawing.Size(342, 191);
            this.PplusLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PplusLogo.TabIndex = 43;
            this.PplusLogo.TabStop = false;
            this.PplusLogo.Click += new System.EventHandler(this.PplusLogo_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.lcarsPicardEra1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PplusLogo);
            this.Controls.Add(this.WatchOnPPlus);
            this.Controls.Add(this.WatchButton);
            this.Controls.Add(this.stationRegButton);
            this.Controls.Add(this.stardateLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.starshipRegButton);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.AppTitleLabel);
            this.Controls.Add(this.outputLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCARS DATABASE ACCESS    ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PplusLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label headingLabel;
        private TextBox inputText;
        private Label AppTitleLabel;
        private Label selectionLabel;
        private Button starshipRegButton;
        private Button exitButton;
        private Label infoTextBox;
        private Button confirmButton;
        private Button clearButton;
        private Label stardateLabel;
        private Button stationRegButton;
        private Button WatchButton;
        private Label outputLabel;
        private LinkLabel WatchOnPPlus;
        private PictureBox PplusLogo;
        }
    }