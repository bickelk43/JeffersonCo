namespace PaperCutDesktopManager_Alpha
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameSearchLbl = new System.Windows.Forms.Label();
            this.usernameSearchTextBox = new System.Windows.Forms.TextBox();
            this.usernameSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printingDisabledComboBox = new System.Windows.Forms.ComboBox();
            this.restrictedComboBox = new System.Windows.Forms.ComboBox();
            this.modifyCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pagesPrintedTextBox = new System.Windows.Forms.TextBox();
            this.pagesPrinted = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.printJobsTextBox = new System.Windows.Forms.TextBox();
            this.jobsLbl = new System.Windows.Forms.Label();
            this.cardNumTextBox = new System.Windows.Forms.TextBox();
            this.cardNumLbl = new System.Windows.Forms.Label();
            this.restrictedLbl = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.balTextBox = new System.Windows.Forms.TextBox();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.syncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.usernameSearchLbl);
            this.splitContainer1.Panel1.Controls.Add(this.usernameSearchTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.usernameSearchButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.printingDisabledComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.restrictedComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.modifyCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pagesPrintedTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.pagesPrinted);
            this.splitContainer1.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.updateUserButton);
            this.splitContainer1.Panel2.Controls.Add(this.notesTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.notesLbl);
            this.splitContainer1.Panel2.Controls.Add(this.printJobsTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.jobsLbl);
            this.splitContainer1.Panel2.Controls.Add(this.cardNumTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.cardNumLbl);
            this.splitContainer1.Panel2.Controls.Add(this.restrictedLbl);
            this.splitContainer1.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.emailLbl);
            this.splitContainer1.Panel2.Controls.Add(this.deptTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.departmentLbl);
            this.splitContainer1.Panel2.Controls.Add(this.balTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.balanceLbl);
            this.splitContainer1.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.fullNameLbl);
            this.splitContainer1.Size = new System.Drawing.Size(477, 330);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usernameSearchLbl
            // 
            this.usernameSearchLbl.AutoSize = true;
            this.usernameSearchLbl.Location = new System.Drawing.Point(3, 12);
            this.usernameSearchLbl.Name = "usernameSearchLbl";
            this.usernameSearchLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameSearchLbl.TabIndex = 2;
            this.usernameSearchLbl.Text = "Username";
            // 
            // usernameSearchTextBox
            // 
            this.usernameSearchTextBox.Location = new System.Drawing.Point(6, 28);
            this.usernameSearchTextBox.Name = "usernameSearchTextBox";
            this.usernameSearchTextBox.Size = new System.Drawing.Size(162, 20);
            this.usernameSearchTextBox.TabIndex = 1;
            // 
            // usernameSearchButton
            // 
            this.usernameSearchButton.Location = new System.Drawing.Point(6, 54);
            this.usernameSearchButton.Name = "usernameSearchButton";
            this.usernameSearchButton.Size = new System.Drawing.Size(162, 29);
            this.usernameSearchButton.TabIndex = 2;
            this.usernameSearchButton.Text = "Search";
            this.usernameSearchButton.UseVisualStyleBackColor = true;
            this.usernameSearchButton.Click += new System.EventHandler(this.usernameSearchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(30, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 100;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // printingDisabledComboBox
            // 
            this.printingDisabledComboBox.Enabled = false;
            this.printingDisabledComboBox.FormattingEnabled = true;
            this.printingDisabledComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.printingDisabledComboBox.Location = new System.Drawing.Point(186, 144);
            this.printingDisabledComboBox.Name = "printingDisabledComboBox";
            this.printingDisabledComboBox.Size = new System.Drawing.Size(81, 21);
            this.printingDisabledComboBox.TabIndex = 11;
            // 
            // restrictedComboBox
            // 
            this.restrictedComboBox.Enabled = false;
            this.restrictedComboBox.FormattingEnabled = true;
            this.restrictedComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.restrictedComboBox.Location = new System.Drawing.Point(177, 67);
            this.restrictedComboBox.Name = "restrictedComboBox";
            this.restrictedComboBox.Size = new System.Drawing.Size(90, 21);
            this.restrictedComboBox.TabIndex = 6;
            // 
            // modifyCheckBox
            // 
            this.modifyCheckBox.AutoSize = true;
            this.modifyCheckBox.Location = new System.Drawing.Point(9, 294);
            this.modifyCheckBox.Name = "modifyCheckBox";
            this.modifyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.modifyCheckBox.TabIndex = 99;
            this.modifyCheckBox.TabStop = false;
            this.modifyCheckBox.UseVisualStyleBackColor = true;
            this.modifyCheckBox.CheckedChanged += new System.EventHandler(this.modifyCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Disabled Printing";
            // 
            // pagesPrintedTextBox
            // 
            this.pagesPrintedTextBox.Location = new System.Drawing.Point(98, 145);
            this.pagesPrintedTextBox.Name = "pagesPrintedTextBox";
            this.pagesPrintedTextBox.ReadOnly = true;
            this.pagesPrintedTextBox.Size = new System.Drawing.Size(82, 20);
            this.pagesPrintedTextBox.TabIndex = 10;
            // 
            // pagesPrinted
            // 
            this.pagesPrinted.AutoSize = true;
            this.pagesPrinted.Location = new System.Drawing.Point(95, 129);
            this.pagesPrinted.Name = "pagesPrinted";
            this.pagesPrinted.Size = new System.Drawing.Size(73, 13);
            this.pagesPrinted.TabIndex = 22;
            this.pagesPrinted.Text = "Pages Printed";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(110, 289);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(191, 289);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(75, 23);
            this.updateUserButton.TabIndex = 13;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(9, 184);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(257, 99);
            this.notesTextBox.TabIndex = 12;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(6, 168);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(35, 13);
            this.notesLbl.TabIndex = 18;
            this.notesLbl.Text = "Notes";
            // 
            // printJobsTextBox
            // 
            this.printJobsTextBox.Location = new System.Drawing.Point(10, 145);
            this.printJobsTextBox.Name = "printJobsTextBox";
            this.printJobsTextBox.ReadOnly = true;
            this.printJobsTextBox.Size = new System.Drawing.Size(82, 20);
            this.printJobsTextBox.TabIndex = 9;
            // 
            // jobsLbl
            // 
            this.jobsLbl.AutoSize = true;
            this.jobsLbl.Location = new System.Drawing.Point(7, 129);
            this.jobsLbl.Name = "jobsLbl";
            this.jobsLbl.Size = new System.Drawing.Size(53, 13);
            this.jobsLbl.TabIndex = 16;
            this.jobsLbl.Text = "Print Jobs";
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Location = new System.Drawing.Point(177, 106);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.ReadOnly = true;
            this.cardNumTextBox.Size = new System.Drawing.Size(89, 20);
            this.cardNumTextBox.TabIndex = 8;
            // 
            // cardNumLbl
            // 
            this.cardNumLbl.AutoSize = true;
            this.cardNumLbl.Location = new System.Drawing.Point(174, 90);
            this.cardNumLbl.Name = "cardNumLbl";
            this.cardNumLbl.Size = new System.Drawing.Size(69, 13);
            this.cardNumLbl.TabIndex = 14;
            this.cardNumLbl.Text = "Card Number";
            // 
            // restrictedLbl
            // 
            this.restrictedLbl.AutoSize = true;
            this.restrictedLbl.Location = new System.Drawing.Point(174, 51);
            this.restrictedLbl.Name = "restrictedLbl";
            this.restrictedLbl.Size = new System.Drawing.Size(55, 13);
            this.restrictedLbl.TabIndex = 12;
            this.restrictedLbl.Text = "Restricted";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(9, 106);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(162, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(6, 90);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Location = new System.Drawing.Point(9, 67);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.ReadOnly = true;
            this.deptTextBox.Size = new System.Drawing.Size(162, 20);
            this.deptTextBox.TabIndex = 5;
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Location = new System.Drawing.Point(6, 51);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(62, 13);
            this.departmentLbl.TabIndex = 8;
            this.departmentLbl.Text = "Department";
            // 
            // balTextBox
            // 
            this.balTextBox.Location = new System.Drawing.Point(177, 28);
            this.balTextBox.Name = "balTextBox";
            this.balTextBox.ReadOnly = true;
            this.balTextBox.Size = new System.Drawing.Size(89, 20);
            this.balTextBox.TabIndex = 4;
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(174, 12);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(46, 13);
            this.balanceLbl.TabIndex = 6;
            this.balanceLbl.Text = "Balance";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(9, 28);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // fullNameLbl
            // 
            this.fullNameLbl.AutoSize = true;
            this.fullNameLbl.Location = new System.Drawing.Point(6, 12);
            this.fullNameLbl.Name = "fullNameLbl";
            this.fullNameLbl.Size = new System.Drawing.Size(54, 13);
            this.fullNameLbl.TabIndex = 0;
            this.fullNameLbl.Text = "Full Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // syncToolStripMenuItem
            // 
            this.syncToolStripMenuItem.Name = "syncToolStripMenuItem";
            this.syncToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.syncToolStripMenuItem.Text = "Sync";
            this.syncToolStripMenuItem.Click += new System.EventHandler(this.syncToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(501, 369);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaperCut Easy Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label usernameSearchLbl;
        private System.Windows.Forms.TextBox usernameSearchTextBox;
        private System.Windows.Forms.Button usernameSearchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.TextBox printJobsTextBox;
        private System.Windows.Forms.Label jobsLbl;
        private System.Windows.Forms.TextBox cardNumTextBox;
        private System.Windows.Forms.Label cardNumLbl;
        private System.Windows.Forms.Label restrictedLbl;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.TextBox balTextBox;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLbl;
        private System.Windows.Forms.TextBox pagesPrintedTextBox;
        private System.Windows.Forms.Label pagesPrinted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox modifyCheckBox;
        private System.Windows.Forms.ComboBox restrictedComboBox;
        private System.Windows.Forms.ComboBox printingDisabledComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem syncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

