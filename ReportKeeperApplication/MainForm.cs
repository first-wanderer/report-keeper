using System;
using System.IO;
using System.Windows.Forms;


namespace ReportKeeperApplication
{
    public partial class MainForm : Form
    {
        DateTime _start;
        DateTime _start_day;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private string MY_DOC_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string reportFilePath = null;
        private float trackedCounter = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public MainForm()
        {
            InitializeComponent();

            this.readingSettings();

            this.timer1.Interval = 3600000;
            this.timer1.Start();

            this.timer2.Interval = 60000;
            this.timer2.Start();

            this.startNewDay();
        }

        private void startNewDay()
        {
            _start_day = DateTime.Now;
            this.reportFilePath = MY_DOC_PATH + @"\timereport-" + this._start_day.Month.ToString("00") + "-" + this._start_day.Year + ".csv";

            this.trackedCounter = 0;
            this.workedTime.Text = "0:00";

            this.resetFields();

            this.timer2.Enabled = false;
            this.timer2.Enabled = true;
        }

        private void resetFields()
        {
            this.desc.Text = "";
            this.time.Text = "1.0";
            this.date.Text = this._start_day.Month + "/" + this._start_day.Day + "/" + this._start_day.Year;
            this._start = DateTime.Now;

            this.timer1.Enabled = false;
            this.timer1.Enabled = true;

            this.trackedTime.Text = this.trackedCounter.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.projectTaskComboBox.SelectedItem.ToString() != "" && this.desc.Text != "" && this.time.Text != "" && this.date.Text != "")
            {
                string taskDuration = this.time.Text;
                taskDuration = taskDuration.Contains(",") ? taskDuration.Replace(",", ".") : taskDuration;

                string[] newReportRecord = { this.projectTaskComboBox.SelectedItem.ToString() + ","
                            + taskDuration + ","
                            + "\""+this.desc.Text + "\","
                            + this.date.Text + ","
                            + this.date.Text };

                try
                {
                    File.AppendAllLines(this.reportFilePath, newReportRecord);

                    this.Visible = false;
                    this.trackedCounter += float.Parse(taskDuration);

                    this.resetFields();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error of record saving. Try to close report file and save record again.\r\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error.\r\n" + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.BringToFront();
            this.Focus();
            this.Activate();
            TimeSpan elapsed = DateTime.Now - this._start;
            var minutes = this.realTimeToolStripMenuItem.Checked ? elapsed.Minutes.ToString("D2") : (elapsed.Minutes / 6).ToString();
            this.time.Text = elapsed.Hours + "." + minutes;
            TimeSpan elapsed_day = DateTime.Now - this._start_day;
            this.workedTime.Text = elapsed_day.Hours + ":" + elapsed_day.Minutes.ToString("D2");
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - this._start;
            var minutes = this.realTimeToolStripMenuItem.Checked ? elapsed.Minutes.ToString("D2") : (elapsed.Minutes / 6).ToString();
            this.time.Text = elapsed.Hours + "." + minutes;
            TimeSpan elapsed_day = DateTime.Now - this._start_day;
            this.workedTime.Text = elapsed_day.Hours + ":" + elapsed_day.Minutes.ToString("D2");
        }

        private void readingSettings()
        {
            this.projectTaskComboBox.Items.Clear();
            string[] projects = Properties.Settings.Default.defaultProjects.Split(',');
            this.projectTaskComboBox.Items.AddRange(projects);
            this.realTimeToolStripMenuItem.Checked = Properties.Settings.Default.realTime;
            this.topMostToolStripMenuItem.Checked = Properties.Settings.Default.topMost;
            this.TopMost = Properties.Settings.Default.topMost;
        }

        private void workedLabel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.startNewDay();
            }
        }

        private void trackedLabel_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                float newTrackedTime = 0;
                if (File.Exists(this.reportFilePath))
                {
                    try
                    {
                        string currentDay = this.date.Text.Split('/')[1];
                        string[] reports = File.ReadAllLines(this.reportFilePath);
                        foreach (string reportRecord in reports)
                        {
                            string[] recordValues = reportRecord.Split(',');
                            string recordDay = recordValues[recordValues.Length-1].Split('/')[1];
                            if (recordDay == currentDay)
                            {
                                newTrackedTime += float.Parse(recordValues[1]);
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error of record reading. Try to close report file and update tracked time again.\r\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown error.\r\n" + ex.Message);
                    }
                }

                if(newTrackedTime > 0)
                {
                    this.trackedCounter = newTrackedTime;
                    this.trackedTime.Text = this.trackedCounter.ToString();
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Trap WM_SYSCOMMAND, SC_MINIMIZE
            if (m.Msg == 0x112 && m.WParam.ToInt32() == 0xf020)
            {
                this.Visible = false;
                return;
            }
            base.WndProc(ref m);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!this.Visible)
                {
                    timer1_Tick(sender, e);
                }
                else
                {
                    this.Visible = false;
                }
            }
        }

        private void realTimeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.realTime != this.realTimeToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.realTime = this.realTimeToolStripMenuItem.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action updateSettings = readingSettings;
            settingsChangeForm changeProjectsForm = new settingsChangeForm(updateSettings);
            changeProjectsForm.Show();
        }

        private void topMostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.topMost != this.topMostToolStripMenuItem.Checked)
            {
                Properties.Settings.Default.topMost = this.topMostToolStripMenuItem.Checked;
                Properties.Settings.Default.Save();
                this.TopMost = Properties.Settings.Default.topMost;
            }
        }
    }
}
