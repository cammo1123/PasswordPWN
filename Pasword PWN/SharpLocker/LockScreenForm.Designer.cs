namespace SharpLocker
{
    partial class LockScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockScreenForm));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ProfileIcon = new System.Windows.Forms.PictureBox();
            this.SubmitPasswordButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(0, 230);
            this.UserNameLabel.MinimumSize = new System.Drawing.Size(400, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(400, 60);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "label2";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 20F);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PasswordTextBox.Location = new System.Drawing.Point(18, 304);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(325, 38);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // ProfileIcon
            // 
            this.ProfileIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfileIcon.BackColor = System.Drawing.Color.Transparent;
            this.ProfileIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileIcon.Image = ((System.Drawing.Image)(resources.GetObject("ProfileIcon.Image")));
            this.ProfileIcon.Location = new System.Drawing.Point(101, 28);
            this.ProfileIcon.Name = "ProfileIcon";
            this.ProfileIcon.Size = new System.Drawing.Size(199, 199);
            this.ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileIcon.TabIndex = 1;
            this.ProfileIcon.TabStop = false;
            this.ProfileIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SubmitPasswordButton
            // 
            this.SubmitPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitPasswordButton.AutoSize = true;
            this.SubmitPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitPasswordButton.BackgroundImage")));
            this.SubmitPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitPasswordButton.FlatAppearance.BorderSize = 0;
            this.SubmitPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitPasswordButton.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitPasswordButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SubmitPasswordButton.Location = new System.Drawing.Point(343, 304);
            this.SubmitPasswordButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitPasswordButton.Name = "SubmitPasswordButton";
            this.SubmitPasswordButton.Size = new System.Drawing.Size(38, 38);
            this.SubmitPasswordButton.TabIndex = 9;
            this.SubmitPasswordButton.UseVisualStyleBackColor = true;
            this.SubmitPasswordButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Controls.Add(this.SubmitPasswordButton);
            this.panel1.Controls.Add(this.ProfileIcon);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(226, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 346);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.panel2.BackgroundImage = global::SharpLocker.Properties.Resources.Background;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 11;
            // 
            // LockScreenForm
            // 
            this.AcceptButton = this.SubmitPasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "LockScreenForm";
            this.Load += new System.EventHandler(this.LockScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox ProfileIcon;
        private System.Windows.Forms.Button SubmitPasswordButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

