using System;
using System.Windows.Forms;
using CookComputing.XmlRpc;
using System.Configuration;


namespace PaperCutDesktopManager_Alpha
{
    public partial class mainForm : Form
    {
        static ServerCommandProxy _serverProxy;

        public mainForm()
        {
            InitializeComponent();
        }

        public void UserInfo()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = ConfigurationManager.AppSettings;

                string authToken = config.AppSettings.Settings["Pass"].Value; //maybe use a config file for pass and server info
                string server = config.AppSettings.Settings["Server"].Value;

                string user = usernameSearchTextBox.Text;
                
                // Create an instance of the server command proxy class.
                _serverProxy = new ServerCommandProxy(server, 9191, authToken);

                GetUserInfo(user);

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void GetUserInfo(string user)
        {
            try
            {
                if (usernameSearchTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Enter a user to search for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!_serverProxy.UserExists(user))
                {
                    MessageBox.Show("User " + user + " does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fullNameTextBox.Text = _serverProxy.GetUserProperty(user, "full-name");
                    balTextBox.Text = _serverProxy.GetUserProperty(user, "balance");
                    emailTextBox.Text = _serverProxy.GetUserProperty(user, "email");
                    deptTextBox.Text = _serverProxy.GetUserProperty(user, "department");
                    cardNumTextBox.Text = _serverProxy.GetUserProperty(user, "card-number");
                    printJobsTextBox.Text = _serverProxy.GetUserProperty(user, "print-stats.job-count");
                    restrictedComboBox.Text = _serverProxy.GetUserProperty(user, "restricted");
                    pagesPrintedTextBox.Text = _serverProxy.GetUserProperty(user, "print-stats.page-count");
                    notesTextBox.Text = _serverProxy.GetUserProperty(user, "notes");
                    printingDisabledComboBox.Text = _serverProxy.GetUserProperty(user, "disabled-print");
                }
            }
            catch (XmlRpcFaultException fex)
            {
                MessageBox.Show("Fault: " + fex.FaultCode.ToString() + "\n" + fex.FaultString.ToString() , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void ModifyUser(string user)
        {
            if(balTextBox.Text == string.Empty)
            {
                MessageBox.Show("Search for a user to update", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    // set some properties of the user
                    _serverProxy.SetUserProperty(user, "card-number", cardNumTextBox.Text);
                    _serverProxy.SetUserProperty(user, "department", deptTextBox.Text);
                    _serverProxy.SetUserProperty(user, "email", emailTextBox.Text);
                    _serverProxy.SetUserProperty(user, "full-name", fullNameTextBox.Text);
                    _serverProxy.SetUserProperty(user, "notes", notesTextBox.Text);
                    _serverProxy.SetUserProperty(user, "restricted", restrictedComboBox.Text);
                    _serverProxy.SetUserProperty(user, "disabled-print", printingDisabledComboBox.Text);
                    _serverProxy.SetUserAccountBalance(user, Convert.ToDouble(balTextBox.Text), "", "");

                    ResetForm();
                    MessageBox.Show(_serverProxy.GetUserProperty(user, "full-name") + " has been updated","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    fullNameTextBox.Text = string.Empty;
                    deptTextBox.Text = string.Empty;
                    emailTextBox.Text = string.Empty;
                    printJobsTextBox.Text = string.Empty;
                    pagesPrintedTextBox.Text = string.Empty;
                    balTextBox.Text = string.Empty;
                    restrictedComboBox.Text = string.Empty;
                    cardNumTextBox.Text = string.Empty;
                    printingDisabledComboBox.Text = string.Empty;
                    notesTextBox.Text = string.Empty;
                    usernameSearchTextBox.Text = string.Empty;
                }
                catch (XmlRpcFaultException fex)
                {
                    MessageBox.Show("Fault: " + fex.FaultCode.ToString() + "\n" + fex.FaultString.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void usernameSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            string user = usernameSearchTextBox.Text;
            ModifyUser(user);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modifyCheckBox.Checked = true;
            updateUserButton.Enabled = false;
            restrictedComboBox.Enabled = false;
            printingDisabledComboBox.Enabled = false;
            this.AcceptButton = usernameSearchButton;
        }

        private void ResetForm()
        {
            fullNameTextBox.ReadOnly = true;
            deptTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            balTextBox.ReadOnly = true;
            restrictedComboBox.Enabled = false;
            cardNumTextBox.ReadOnly = true;
            printingDisabledComboBox.Enabled = false;
            notesTextBox.ReadOnly = true;
            updateUserButton.Enabled = false;
        }

        private void modifyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (modifyCheckBox.Checked == true)
            {
                fullNameTextBox.ReadOnly = true;
                deptTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                balTextBox.ReadOnly = true;
                restrictedComboBox.Enabled = false;
                cardNumTextBox.ReadOnly = true;
                printingDisabledComboBox.Enabled = false;
                notesTextBox.ReadOnly = true;
                updateUserButton.Enabled = false;
            }
            else
            {
                fullNameTextBox.ReadOnly = false;
                deptTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                balTextBox.ReadOnly = false;
                restrictedComboBox.Enabled = true;
                cardNumTextBox.ReadOnly = false;
                printingDisabledComboBox.Enabled = true;
                notesTextBox.ReadOnly = false;
                updateUserButton.Enabled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ResetForm();
            fullNameTextBox.Text = string.Empty;
            deptTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            printJobsTextBox.Text = string.Empty;
            pagesPrintedTextBox.Text = string.Empty;
            balTextBox.Text = string.Empty;
            restrictedComboBox.Text = string.Empty;
            cardNumTextBox.Text = string.Empty;
            printingDisabledComboBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;
            usernameSearchTextBox.Text = string.Empty;
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Would you like to preform a full User/Group sync?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var appSettings = ConfigurationManager.AppSettings;

                    string authToken = config.AppSettings.Settings["Pass"].Value; //maybe use a config file for pass and server info
                    string server = config.AppSettings.Settings["Server"].Value;

                    // Create an instance of the server command proxy class.
                    _serverProxy = new ServerCommandProxy(server, 9191, authToken);
                    _serverProxy.PerformUserAndGroupSync();

                    MessageBox.Show("Sync started.\nProcess will run in the background.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sync cancelled.\nNo action", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm newConfig = new ConfigForm();
            newConfig.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
