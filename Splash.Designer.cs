namespace StarshipRegistryGUI
    {
    partial class Splash
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
            this.splashSubhead = new System.Windows.Forms.Label();
            this.splNameCta = new System.Windows.Forms.Label();
            this.splNameInput = new System.Windows.Forms.TextBox();
            this.splashLogout = new System.Windows.Forms.Button();
            this.splashLogin = new System.Windows.Forms.Button();
            this.accessStatus = new System.Windows.Forms.Label();
            this.lcarsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splashSubhead
            // 
            this.splashSubhead.BackColor = System.Drawing.Color.Transparent;
            this.splashSubhead.Font = new System.Drawing.Font("Antonio", 23.77358F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splashSubhead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.splashSubhead.Location = new System.Drawing.Point(14, 260);
            this.splashSubhead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.splashSubhead.Name = "splashSubhead";
            this.splashSubhead.Size = new System.Drawing.Size(744, 47);
            this.splashSubhead.TabIndex = 21;
            this.splashSubhead.Text = "AUTHORIZED ACCESS ONLY\r\n";
            this.splashSubhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splNameCta
            // 
            this.splNameCta.BackColor = System.Drawing.Color.Transparent;
            this.splNameCta.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splNameCta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.splNameCta.Location = new System.Drawing.Point(14, 328);
            this.splNameCta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.splNameCta.Name = "splNameCta";
            this.splNameCta.Size = new System.Drawing.Size(362, 30);
            this.splNameCta.TabIndex = 22;
            this.splNameCta.Text = "ENTER YOUR NAME:";
            this.splNameCta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splNameInput
            // 
            this.splNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.splNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.splNameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.splNameInput.Font = new System.Drawing.Font("Antonio", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(191)))), ((int)(((byte)(189)))));
            this.splNameInput.Location = new System.Drawing.Point(382, 328);
            this.splNameInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splNameInput.MaxLength = 25;
            this.splNameInput.Name = "splNameInput";
            this.splNameInput.Size = new System.Drawing.Size(377, 28);
            this.splNameInput.TabIndex = 23;
            // 
            // splashLogout
            // 
            this.splashLogout.BackColor = System.Drawing.Color.Transparent;
            this.splashLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splashLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splashLogout.FlatAppearance.BorderSize = 0;
            this.splashLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.splashLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.splashLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splashLogout.Location = new System.Drawing.Point(765, 334);
            this.splashLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splashLogout.Name = "splashLogout";
            this.splashLogout.Size = new System.Drawing.Size(170, 55);
            this.splashLogout.TabIndex = 24;
            this.splashLogout.UseVisualStyleBackColor = true;
            this.splashLogout.Click += new System.EventHandler(this.splashLogout_Click);
            // 
            // splashLogin
            // 
            this.splashLogin.BackColor = System.Drawing.Color.Transparent;
            this.splashLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splashLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splashLogin.FlatAppearance.BorderSize = 0;
            this.splashLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.splashLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.splashLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.splashLogin.Location = new System.Drawing.Point(765, 271);
            this.splashLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splashLogin.Name = "splashLogin";
            this.splashLogin.Size = new System.Drawing.Size(170, 54);
            this.splashLogin.TabIndex = 25;
            this.splashLogin.UseVisualStyleBackColor = true;
            this.splashLogin.Click += new System.EventHandler(this.splashLogin_Click);
            // 
            // accessStatus
            // 
            this.accessStatus.BackColor = System.Drawing.Color.Transparent;
            this.accessStatus.Font = new System.Drawing.Font("Antonio", 27.84906F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accessStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.accessStatus.Location = new System.Drawing.Point(13, 377);
            this.accessStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accessStatus.Name = "accessStatus";
            this.accessStatus.Size = new System.Drawing.Size(744, 75);
            this.accessStatus.TabIndex = 26;
            this.accessStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lcarsLabel
            // 
            this.lcarsLabel.BackColor = System.Drawing.Color.Transparent;
            this.lcarsLabel.Font = new System.Drawing.Font("Antonio Light", 42.11321F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lcarsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(176)))));
            this.lcarsLabel.Location = new System.Drawing.Point(13, 164);
            this.lcarsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lcarsLabel.Name = "lcarsLabel";
            this.lcarsLabel.Size = new System.Drawing.Size(744, 93);
            this.lcarsLabel.TabIndex = 29;
            this.lcarsLabel.Text = "LCARS NETWORK ACCESS";
            this.lcarsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            this.AcceptButton = this.splashLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.BackgroundImage = global::StarshipRegistryGUI.Properties.Resources.splashRedesign;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.splashLogout;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.lcarsLabel);
            this.Controls.Add(this.accessStatus);
            this.Controls.Add(this.splashLogin);
            this.Controls.Add(this.splashLogout);
            this.Controls.Add(this.splNameInput);
            this.Controls.Add(this.splNameCta);
            this.Controls.Add(this.splashSubhead);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCARS NETWORK ACCESS";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private Label splashSubhead;
        private Label splNameCta;
        private Button splashLogout;
        private Button splashLogin;
        private Label accessStatus;
        private Label lcarsLabel;
        public TextBox splNameInput;
        }
    }