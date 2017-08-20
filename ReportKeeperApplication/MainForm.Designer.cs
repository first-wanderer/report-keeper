using System;

namespace ReportKeeperApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.realTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.projectTaskComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.workedTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackedTime = new System.Windows.Forms.Label();
            this.WorkedLabel = new System.Windows.Forms.Label();
            this.TrackedLabel = new System.Windows.Forms.Label();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSettings,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // toolStripMenuSettings
            // 
            this.toolStripMenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realTimeToolStripMenuItem,
            this.projectsToolStripMenuItem});
            this.toolStripMenuSettings.Name = "toolStripMenuSettings";
            this.toolStripMenuSettings.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuSettings.Text = "Settings";
            // 
            // realTimeToolStripMenuItem
            // 
            this.realTimeToolStripMenuItem.CheckOnClick = true;
            this.realTimeToolStripMenuItem.Name = "realTimeToolStripMenuItem";
            this.realTimeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.realTimeToolStripMenuItem.Text = "Real time";
            this.realTimeToolStripMenuItem.CheckedChanged += new System.EventHandler(this.realTimeToolStripMenuItem_CheckedChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(212, 12);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(47, 20);
            this.time.TabIndex = 2;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(12, 39);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(349, 20);
            this.desc.TabIndex = 3;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(265, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(96, 20);
            this.date.TabIndex = 4;
            // 
            // projectTaskComboBox
            // 
            this.projectTaskComboBox.FormattingEnabled = true;
            this.projectTaskComboBox.Location = new System.Drawing.Point(12, 12);
            this.projectTaskComboBox.Name = "projectTaskComboBox";
            this.projectTaskComboBox.Size = new System.Drawing.Size(194, 21);
            this.projectTaskComboBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(367, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 49);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "report keeper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // workedTime
            // 
            this.workedTime.AutoSize = true;
            this.workedTime.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.workedTime.Location = new System.Drawing.Point(468, 22);
            this.workedTime.Name = "workedTime";
            this.workedTime.Size = new System.Drawing.Size(74, 35);
            this.workedTime.TabIndex = 7;
            this.workedTime.Text = "0:00";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackedTime
            // 
            this.trackedTime.AutoSize = true;
            this.trackedTime.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.trackedTime.Location = new System.Drawing.Point(548, 22);
            this.trackedTime.Name = "trackedTime";
            this.trackedTime.Size = new System.Drawing.Size(32, 35);
            this.trackedTime.TabIndex = 8;
            this.trackedTime.Text = "0.0";
            // 
            // WorkedLabel
            // 
            this.WorkedLabel.AutoSize = true;
            this.WorkedLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.WorkedLabel.Location = new System.Drawing.Point(471, 5);
            this.WorkedLabel.Name = "WorkedLabel";
            this.WorkedLabel.Size = new System.Drawing.Size(63, 17);
            this.WorkedLabel.TabIndex = 9;
            this.WorkedLabel.Text = "Worked:";
            this.WorkedLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.workedLabel_Click);
            // 
            // TrackedLabel
            // 
            this.TrackedLabel.AutoSize = true;
            this.TrackedLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TrackedLabel.Location = new System.Drawing.Point(551, 5);
            this.TrackedLabel.Name = "TrackedLabel";
            this.TrackedLabel.Size = new System.Drawing.Size(64, 17);
            this.TrackedLabel.TabIndex = 10;
            this.TrackedLabel.Text = "Tracked:";
            this.TrackedLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trackedLabel_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.projectsToolStripMenuItem.Text = "Change projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 69);
            this.Controls.Add(this.TrackedLabel);
            this.Controls.Add(this.WorkedLabel);
            this.Controls.Add(this.trackedTime);
            this.Controls.Add(this.workedTime);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectTaskComboBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "report keeper";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.ComboBox projectTaskComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label workedTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label trackedTime;
        private System.Windows.Forms.Label WorkedLabel;
        private System.Windows.Forms.Label TrackedLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem realTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
    }
}

