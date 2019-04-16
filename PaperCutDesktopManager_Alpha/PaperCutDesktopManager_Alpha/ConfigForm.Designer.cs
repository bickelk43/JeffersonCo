namespace PaperCutDesktopManager_Alpha
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label1 = new System.Windows.Forms.Label();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.papercutAdminTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.installLocationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.installFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openInstallFolderBrowserDialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Address (IP)";
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(157, 58);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(330, 20);
            this.serverAddressTextBox.TabIndex = 3;
            // 
            // papercutAdminTextBox
            // 
            this.papercutAdminTextBox.Location = new System.Drawing.Point(157, 93);
            this.papercutAdminTextBox.Name = "papercutAdminTextBox";
            this.papercutAdminTextBox.PasswordChar = '•';
            this.papercutAdminTextBox.Size = new System.Drawing.Size(330, 20);
            this.papercutAdminTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PaperCut Admin Password\r\n";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(412, 119);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // installLocationTextBox
            // 
            this.installLocationTextBox.Location = new System.Drawing.Point(157, 22);
            this.installLocationTextBox.Name = "installLocationTextBox";
            this.installLocationTextBox.Size = new System.Drawing.Size(330, 20);
            this.installLocationTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Install Location";
            // 
            // openInstallFolderBrowserDialogButton
            // 
            this.openInstallFolderBrowserDialogButton.Location = new System.Drawing.Point(496, 21);
            this.openInstallFolderBrowserDialogButton.Name = "openInstallFolderBrowserDialogButton";
            this.openInstallFolderBrowserDialogButton.Size = new System.Drawing.Size(25, 22);
            this.openInstallFolderBrowserDialogButton.TabIndex = 2;
            this.openInstallFolderBrowserDialogButton.Text = "...";
            this.openInstallFolderBrowserDialogButton.UseVisualStyleBackColor = true;
            this.openInstallFolderBrowserDialogButton.Click += new System.EventHandler(this.openInstallFolderBrowserDialogButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(535, 154);
            this.Controls.Add(this.openInstallFolderBrowserDialogButton);
            this.Controls.Add(this.installLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.papercutAdminTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverAddressTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.TextBox papercutAdminTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox installLocationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog installFolderBrowserDialog;
        private System.Windows.Forms.Button openInstallFolderBrowserDialogButton;
    }
}