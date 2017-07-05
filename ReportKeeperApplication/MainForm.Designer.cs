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
            this.time = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.projectTaskComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.time1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "report keeper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.time1.Location = new System.Drawing.Point(468, 10);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(110, 50);
            this.time1.TabIndex = 7;
            this.time1.Text = "0:00";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 69);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.projectTaskComboBox);
            this.Controls.Add(this.date);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.time);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "report keeper";
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
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Timer timer2;
    }
}

