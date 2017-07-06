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
            this.ShowInTaskbar = false;
            this.date.Text = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            _start_day = DateTime.Now;
            _start = DateTime.Now;

            this.projectTaskComboBox.Items.Add("Internal.Estimation");

            this.projectTaskComboBox.Items.Add("Axapta build.Bugfixing");
            this.projectTaskComboBox.Items.Add("Axapta build.Code review");
            this.projectTaskComboBox.Items.Add("Axapta build.Communication");
            this.projectTaskComboBox.Items.Add("Axapta build.Development");
            this.projectTaskComboBox.Items.Add("Axapta build.Estimation");
            this.projectTaskComboBox.Items.Add("Axapta build.Investigation");
            this.projectTaskComboBox.Items.Add("Axapta build.Testing");
            this.projectTaskComboBox.Items.Add("Axapta build.Configuration");
            this.time.Text = "1.0";

            this.timer1.Interval = 3600000;
            this.timer1.Start();

            this.timer2.Interval = 60000;
            this.timer2.Start();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.projectTaskComboBox.SelectedItem.ToString() != "" && this.desc.Text != "" && this.time.Text != "" && this.date.Text != "")
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                string[] line = { this.projectTaskComboBox.SelectedItem.ToString() + ","
                            + this.time.Text + ","
                            + "\""+this.desc.Text + "\","
                            + this.date.Text + ","
                            + this.date.Text };

                File.AppendAllLines(mydocpath + @"\timereport.csv", line);

                this.desc.Text = "";
                this.time.Text = "1.0";
                this.date.Text = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
                this.WindowState = FormWindowState.Minimized;
                this._start = DateTime.Now;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Focus();
            this.Activate();
            TimeSpan elapsed = DateTime.Now - this._start;
            this.time.Text = elapsed.Hours + "." + elapsed.Minutes.ToString("D2");
            TimeSpan elapsed_day = DateTime.Now - this._start_day;
            this.time1.Text = elapsed_day.Hours + ":" + elapsed_day.Minutes.ToString("D2");

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - this._start;
            this.time1.Text = elapsed.Hours + "." + elapsed.Minutes.ToString("D2");

            TimeSpan elapsed_day = DateTime.Now - this._start_day;
            this.time1.Text = elapsed_day.Hours + ":" + elapsed_day.Minutes.ToString("D2");

        }
    }
}
