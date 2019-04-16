using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.IO;

namespace PaperCutDesktopManager_Alpha
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            CheckUAC();
            ShowCurrent();
        }

        public void CheckUAC()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var customSettings = ConfigurationManager.GetSection("geoSettings/summary") as NameValueCollection;

            FileStream stream = null;
            string filePath = appSettings["DefaultFilePath"];

            if(File.Exists(filePath))
            {
                // Allow 'Everyone' access to the filepath
                FileSecurity fSecurity = File.GetAccessControl(filePath);
                fSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Read, AccessControlType.Allow));
                File.SetAccessControl(filePath, fSecurity);

                // Attempt to access file.
                try
                {
                    stream = new FileStream(filePath, FileMode.Create);
                    //Debug.WriteLine("Successfully changed " + filePath + " to " + FileMode.Create.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                    stream.Dispose();
                }
            }
        }

        public void EditConfig()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Pass"].Value = papercutAdminTextBox.Text;
            config.AppSettings.Settings["Server"].Value = serverAddressTextBox.Text;
            config.AppSettings.Settings["DefaultFilePath"].Value = installLocationTextBox.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditConfig();
                MessageBox.Show("Config saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Config error.\n" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ShowCurrent()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var customSettings = ConfigurationManager.GetSection("geoSettings/summary") as NameValueCollection;

            papercutAdminTextBox.Text = appSettings["Pass"];
            serverAddressTextBox.Text = appSettings["Server"];
            installLocationTextBox.Text = appSettings["DefaultFilePath"];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void openInstallFolderBrowserDialogButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Reset config to default install location?", "Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (dr == DialogResult.Yes)
            {
                config.AppSettings.Settings["DefaultFilePath"].Value = @"C:\Program Files(x86)\Jefferson Co R - VII\Setup\";
                installLocationTextBox.Text = config.AppSettings.Settings["DefaultFilePath"].Value;
            }
            else
            {
                FolderBrowserDialog newfbd = new FolderBrowserDialog();
                newfbd.ShowDialog();
                installLocationTextBox.Text = newfbd.SelectedPath.ToString();
            }
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = saveButton;
        }
    }
}
