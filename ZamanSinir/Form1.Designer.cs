namespace Win
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.appHizala = new System.Windows.Forms.Timer(this.components);
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logUpdate = new System.Windows.Forms.Timer(this.components);
            this.remainingMinLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.adminButon = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.InnerAdminPanel = new System.Windows.Forms.Panel();
            this.addMinuteLabel = new System.Windows.Forms.Label();
            this.shortcut = new System.Windows.Forms.Button();
            this.openLogRecords = new System.Windows.Forms.Button();
            this.openLogPathFolder = new System.Windows.Forms.Button();
            this.adminExit = new System.Windows.Forms.Button();
            this.addMinute = new System.Windows.Forms.Button();
            this.addMinTextBox = new System.Windows.Forms.TextBox();
            this.logPathTextBox = new System.Windows.Forms.TextBox();
            this.lableLogPath = new System.Windows.Forms.Label();
            this.logPathSelect = new System.Windows.Forms.Button();
            this.killButton = new System.Windows.Forms.Button();
            this.adminPwTextBox = new System.Windows.Forms.TextBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.refreshALertLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.AdminPanel.SuspendLayout();
            this.InnerAdminPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // appHizala
            // 
            this.appHizala.Tick += new System.EventHandler(this.appHizala_Tick);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(80, 20);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(14, 18);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "User Name";
            // 
            // logUpdate
            // 
            this.logUpdate.Tick += new System.EventHandler(this.logUpdate_Tick);
            // 
            // remainingMinLabel
            // 
            this.remainingMinLabel.AutoSize = true;
            this.remainingMinLabel.Location = new System.Drawing.Point(77, 116);
            this.remainingMinLabel.Name = "remainingMinLabel";
            this.remainingMinLabel.Size = new System.Drawing.Size(83, 13);
            this.remainingMinLabel.TabIndex = 6;
            this.remainingMinLabel.Text = "Remaining Min :";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(80, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adminButon
            // 
            this.adminButon.Location = new System.Drawing.Point(630, 56);
            this.adminButon.Name = "adminButon";
            this.adminButon.Size = new System.Drawing.Size(75, 23);
            this.adminButon.TabIndex = 8;
            this.adminButon.Text = "Admin Login";
            this.adminButon.UseVisualStyleBackColor = true;
            this.adminButon.Click += new System.EventHandler(this.adminButon_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.White;
            this.AdminPanel.Controls.Add(this.InnerAdminPanel);
            this.AdminPanel.Controls.Add(this.shortcut);
            this.AdminPanel.Controls.Add(this.logPathTextBox);
            this.AdminPanel.Controls.Add(this.lableLogPath);
            this.AdminPanel.Controls.Add(this.logPathSelect);
            this.AdminPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AdminPanel.Location = new System.Drawing.Point(422, 119);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(366, 424);
            this.AdminPanel.TabIndex = 9;
            this.AdminPanel.Visible = false;
            // 
            // InnerAdminPanel
            // 
            this.InnerAdminPanel.Controls.Add(this.addMinuteLabel);
            this.InnerAdminPanel.Controls.Add(this.openLogRecords);
            this.InnerAdminPanel.Controls.Add(this.killButton);
            this.InnerAdminPanel.Controls.Add(this.openLogPathFolder);
            this.InnerAdminPanel.Controls.Add(this.adminExit);
            this.InnerAdminPanel.Controls.Add(this.addMinute);
            this.InnerAdminPanel.Controls.Add(this.addMinTextBox);
            this.InnerAdminPanel.Enabled = false;
            this.InnerAdminPanel.Location = new System.Drawing.Point(12, 103);
            this.InnerAdminPanel.Name = "InnerAdminPanel";
            this.InnerAdminPanel.Size = new System.Drawing.Size(336, 275);
            this.InnerAdminPanel.TabIndex = 12;
            // 
            // addMinuteLabel
            // 
            this.addMinuteLabel.AutoSize = true;
            this.addMinuteLabel.Location = new System.Drawing.Point(14, 10);
            this.addMinuteLabel.Name = "addMinuteLabel";
            this.addMinuteLabel.Size = new System.Drawing.Size(61, 13);
            this.addMinuteLabel.TabIndex = 11;
            this.addMinuteLabel.Text = "Add Minute";
            // 
            // shortcut
            // 
            this.shortcut.Location = new System.Drawing.Point(29, 52);
            this.shortcut.Name = "shortcut";
            this.shortcut.Size = new System.Drawing.Size(155, 23);
            this.shortcut.TabIndex = 10;
            this.shortcut.Text = "Create Shortcut Startup";
            this.shortcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shortcut.UseVisualStyleBackColor = true;
            this.shortcut.Click += new System.EventHandler(this.shortcut_Click);
            // 
            // openLogRecords
            // 
            this.openLogRecords.Location = new System.Drawing.Point(17, 61);
            this.openLogRecords.Name = "openLogRecords";
            this.openLogRecords.Size = new System.Drawing.Size(155, 23);
            this.openLogRecords.TabIndex = 9;
            this.openLogRecords.Text = "Open Log Records";
            this.openLogRecords.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.openLogRecords.UseVisualStyleBackColor = true;
            this.openLogRecords.Click += new System.EventHandler(this.openLogRecords_Click);
            // 
            // openLogPathFolder
            // 
            this.openLogPathFolder.Location = new System.Drawing.Point(17, 108);
            this.openLogPathFolder.Name = "openLogPathFolder";
            this.openLogPathFolder.Size = new System.Drawing.Size(155, 23);
            this.openLogPathFolder.TabIndex = 8;
            this.openLogPathFolder.Text = "Open Log Path Setting Folder";
            this.openLogPathFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openLogPathFolder.UseVisualStyleBackColor = true;
            this.openLogPathFolder.Click += new System.EventHandler(this.openLogPathFolder_Click);
            // 
            // adminExit
            // 
            this.adminExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adminExit.FlatAppearance.BorderSize = 11;
            this.adminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminExit.ForeColor = System.Drawing.Color.Red;
            this.adminExit.Location = new System.Drawing.Point(17, 198);
            this.adminExit.Name = "adminExit";
            this.adminExit.Size = new System.Drawing.Size(141, 31);
            this.adminExit.TabIndex = 6;
            this.adminExit.Text = "Admin Logout !!!";
            this.adminExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.adminExit.UseVisualStyleBackColor = true;
            this.adminExit.Click += new System.EventHandler(this.adminExit_Click);
            // 
            // addMinute
            // 
            this.addMinute.Location = new System.Drawing.Point(206, 5);
            this.addMinute.Name = "addMinute";
            this.addMinute.Size = new System.Drawing.Size(75, 23);
            this.addMinute.TabIndex = 2;
            this.addMinute.Text = "Add Minute [min]";
            this.addMinute.UseVisualStyleBackColor = true;
            this.addMinute.Click += new System.EventHandler(this.addMinute_Click);
            // 
            // addMinTextBox
            // 
            this.addMinTextBox.Location = new System.Drawing.Point(92, 7);
            this.addMinTextBox.Name = "addMinTextBox";
            this.addMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.addMinTextBox.TabIndex = 1;
            // 
            // logPathTextBox
            // 
            this.logPathTextBox.Location = new System.Drawing.Point(107, 12);
            this.logPathTextBox.Name = "logPathTextBox";
            this.logPathTextBox.Size = new System.Drawing.Size(100, 20);
            this.logPathTextBox.TabIndex = 3;
            // 
            // lableLogPath
            // 
            this.lableLogPath.AutoSize = true;
            this.lableLogPath.Location = new System.Drawing.Point(29, 14);
            this.lableLogPath.Name = "lableLogPath";
            this.lableLogPath.Size = new System.Drawing.Size(50, 13);
            this.lableLogPath.TabIndex = 4;
            this.lableLogPath.Text = "Log Path";
            // 
            // logPathSelect
            // 
            this.logPathSelect.Location = new System.Drawing.Point(221, 9);
            this.logPathSelect.Name = "logPathSelect";
            this.logPathSelect.Size = new System.Drawing.Size(92, 23);
            this.logPathSelect.TabIndex = 5;
            this.logPathSelect.Text = "Log Path Select";
            this.logPathSelect.UseVisualStyleBackColor = true;
            this.logPathSelect.Click += new System.EventHandler(this.logPathSelect_Click);
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(164, 198);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(147, 31);
            this.killButton.TabIndex = 7;
            this.killButton.Text = "Stop and Close Program";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // adminPwTextBox
            // 
            this.adminPwTextBox.Location = new System.Drawing.Point(512, 58);
            this.adminPwTextBox.Name = "adminPwTextBox";
            this.adminPwTextBox.PasswordChar = '*';
            this.adminPwTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminPwTextBox.TabIndex = 10;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Location = new System.Drawing.Point(431, 61);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(69, 13);
            this.adminLabel.TabIndex = 11;
            this.adminLabel.Text = "ADMIN PW :";
            // 
            // refreshALertLabel
            // 
            this.refreshALertLabel.AutoSize = true;
            this.refreshALertLabel.ForeColor = System.Drawing.Color.Red;
            this.refreshALertLabel.Location = new System.Drawing.Point(239, 68);
            this.refreshALertLabel.Name = "refreshALertLabel";
            this.refreshALertLabel.Size = new System.Drawing.Size(97, 13);
            this.refreshALertLabel.TabIndex = 12;
            this.refreshALertLabel.Text = "<- Click for Refresh";
            this.refreshALertLabel.Visible = false;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.userNameLabel);
            this.userPanel.Controls.Add(this.refreshALertLabel);
            this.userPanel.Controls.Add(this.UserNameTextBox);
            this.userPanel.Controls.Add(this.button1);
            this.userPanel.Controls.Add(this.remainingMinLabel);
            this.userPanel.Controls.Add(this.button3);
            this.userPanel.Location = new System.Drawing.Point(12, 65);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(344, 263);
            this.userPanel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 710);
            this.ControlBox = false;
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.adminPwTextBox);
            this.Controls.Add(this.adminButon);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.InnerAdminPanel.ResumeLayout(false);
            this.InnerAdminPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer appHizala;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Timer logUpdate;
        private System.Windows.Forms.Label remainingMinLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button adminButon;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.TextBox addMinTextBox;
        private System.Windows.Forms.Button logPathSelect;
        private System.Windows.Forms.Label lableLogPath;
        private System.Windows.Forms.TextBox logPathTextBox;
        private System.Windows.Forms.Button addMinute;
        private System.Windows.Forms.TextBox adminPwTextBox;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Button adminExit;
        private System.Windows.Forms.Button killButton;
        private System.Windows.Forms.Button openLogPathFolder;
        private System.Windows.Forms.Button openLogRecords;
        private System.Windows.Forms.Label refreshALertLabel;
        private System.Windows.Forms.Button shortcut;
        private System.Windows.Forms.Label addMinuteLabel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel InnerAdminPanel;
    }
}

