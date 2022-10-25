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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.dynamicPhotoBox = new System.Windows.Forms.PictureBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.starshipRegButton = new System.Windows.Forms.Button();
            this.techButton = new System.Windows.Forms.Button();
            this.cultureButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.scienceButton = new System.Windows.Forms.Button();
            this.personnelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dynamicPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dynamicPhotoBox
            // 
            this.dynamicPhotoBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dynamicPhotoBox.BackColor = System.Drawing.Color.Transparent;
            this.dynamicPhotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dynamicPhotoBox.Location = new System.Drawing.Point(1076, 322);
            this.dynamicPhotoBox.Margin = new System.Windows.Forms.Padding(0);
            this.dynamicPhotoBox.Name = "dynamicPhotoBox";
            this.dynamicPhotoBox.Size = new System.Drawing.Size(493, 538);
            this.dynamicPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dynamicPhotoBox.TabIndex = 4;
            this.dynamicPhotoBox.TabStop = false;
            // 
            // headingLabel
            // 
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Antonio", 27.84906F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.headingLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headingLabel.Location = new System.Drawing.Point(237, 322);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(814, 63);
            this.headingLabel.TabIndex = 5;
            this.headingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.Black;
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputText.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.inputText.Location = new System.Drawing.Point(420, 404);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(631, 28);
            this.inputText.TabIndex = 6;
            this.inputText.Enter += new System.EventHandler(this.confirmButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.appTitleLabel.Font = new System.Drawing.Font("Antonio", 33.96227F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.appTitleLabel.Location = new System.Drawing.Point(243, -1);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(1349, 78);
            this.appTitleLabel.TabIndex = 19;
            this.appTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectionLabel
            // 
            this.selectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectionLabel.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.selectionLabel.Location = new System.Drawing.Point(244, 404);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(170, 30);
            this.selectionLabel.TabIndex = 20;
            this.selectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // starshipRegButton
            // 
            this.starshipRegButton.BackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.starshipRegButton;
            this.starshipRegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.starshipRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starshipRegButton.FlatAppearance.BorderSize = 0;
            this.starshipRegButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.starshipRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.starshipRegButton.Location = new System.Drawing.Point(1021, 78);
            this.starshipRegButton.Name = "starshipRegButton";
            this.starshipRegButton.Size = new System.Drawing.Size(173, 49);
            this.starshipRegButton.TabIndex = 22;
            this.starshipRegButton.UseVisualStyleBackColor = false;
            this.starshipRegButton.Click += new System.EventHandler(this.accessBtn_Click);
            // 
            // techButton
            // 
            this.techButton.BackColor = System.Drawing.Color.Transparent;
            this.techButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.techButton;
            this.techButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.techButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.techButton.FlatAppearance.BorderSize = 0;
            this.techButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.techButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.techButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.techButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.techButton.Location = new System.Drawing.Point(1394, 78);
            this.techButton.Name = "techButton";
            this.techButton.Size = new System.Drawing.Size(178, 49);
            this.techButton.TabIndex = 23;
            this.techButton.UseVisualStyleBackColor = false;
            this.techButton.Click += new System.EventHandler(this.techButton_Click);
            // 
            // cultureButton
            // 
            this.cultureButton.BackColor = System.Drawing.Color.Transparent;
            this.cultureButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.cultureButton;
            this.cultureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cultureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cultureButton.FlatAppearance.BorderSize = 0;
            this.cultureButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cultureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cultureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cultureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cultureButton.Location = new System.Drawing.Point(1021, 140);
            this.cultureButton.Name = "cultureButton";
            this.cultureButton.Size = new System.Drawing.Size(173, 49);
            this.cultureButton.TabIndex = 24;
            this.cultureButton.UseVisualStyleBackColor = false;
            this.cultureButton.Click += new System.EventHandler(this.cultureButton_Click);
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
            this.exitButton.Location = new System.Drawing.Point(1394, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(178, 49);
            this.exitButton.TabIndex = 25;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.Color.Transparent;
            this.infoTextBox.Font = new System.Drawing.Font("Antonio Light", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.infoTextBox.Location = new System.Drawing.Point(250, 860);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(1334, 31);
            this.infoTextBox.TabIndex = 30;
            this.infoTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.confirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Location = new System.Drawing.Point(43, 405);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(170, 40);
            this.confirmButton.TabIndex = 31;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.Black;
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.outputTextBox.Location = new System.Drawing.Point(250, 456);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(801, 404);
            this.outputTextBox.TabIndex = 32;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Transparent;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(43, 456);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(170, 40);
            this.clearButton.TabIndex = 33;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // scienceButton
            // 
            this.scienceButton.BackColor = System.Drawing.Color.Transparent;
            this.scienceButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.scienceButton;
            this.scienceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scienceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scienceButton.FlatAppearance.BorderSize = 0;
            this.scienceButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.scienceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.scienceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.scienceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scienceButton.Location = new System.Drawing.Point(1210, 78);
            this.scienceButton.Name = "scienceButton";
            this.scienceButton.Size = new System.Drawing.Size(173, 49);
            this.scienceButton.TabIndex = 34;
            this.scienceButton.UseVisualStyleBackColor = false;
            this.scienceButton.Click += new System.EventHandler(this.scienceButton_Click);
            // 
            // personnelButton
            // 
            this.personnelButton.BackColor = System.Drawing.Color.Transparent;
            this.personnelButton.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.personnelButton;
            this.personnelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personnelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personnelButton.FlatAppearance.BorderSize = 0;
            this.personnelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.personnelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personnelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personnelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personnelButton.Location = new System.Drawing.Point(1210, 140);
            this.personnelButton.Name = "personnelButton";
            this.personnelButton.Size = new System.Drawing.Size(173, 49);
            this.personnelButton.TabIndex = 35;
            this.personnelButton.UseVisualStyleBackColor = false;
            this.personnelButton.Click += new System.EventHandler(this.galaxyMapButton_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.updatedLcars1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.personnelButton);
            this.Controls.Add(this.scienceButton);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.dynamicPhotoBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cultureButton);
            this.Controls.Add(this.techButton);
            this.Controls.Add(this.starshipRegButton);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.appTitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database of Identified Starships";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dynamicPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private PictureBox dynamicPhotoBox;
        private Label headingLabel;
        private TextBox inputText;
        private Label appTitleLabel;
        private Label selectionLabel;
        private Button starshipRegButton;
        private Button techButton;
        private Button cultureButton;
        private Button exitButton;
        private Label infoTextBox;
        private Button confirmButton;
        private TextBox outputTextBox;
        private Button clearButton;
        private Button scienceButton;
        private Button personnelButton;
        }
    }