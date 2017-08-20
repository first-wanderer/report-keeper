using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportKeeperApplication
{
    public partial class settingsChangeForm : Form
    {
        private Action updateSettings;

        public settingsChangeForm(Action sender)
        {
            InitializeComponent();
            this.textBoxSettings.Text = Properties.Settings.Default.defaultProjects;
            updateSettings = sender;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            char[] separator = {','};
            string[] projects = this.textBoxSettings.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string defaultProjects = "";
            foreach (var project in projects)
            {
                defaultProjects += project.Trim() + ",";
            }        
            Properties.Settings.Default.defaultProjects = defaultProjects.TrimEnd(',');
            Properties.Settings.Default.Save();
            updateSettings();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
