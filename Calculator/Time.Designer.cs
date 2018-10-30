namespace Calculator
{
    partial class Time
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnCalculateTime = new System.Windows.Forms.Button();
            this.dtPickEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTimeStarted = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.dtPickStart = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSCustomaryUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lblTimeElapsed, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCalculateTime, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtPickEnd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTimeStarted, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTimeNow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtPickStart, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(155, 236);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(277, 62);
            this.lblTimeElapsed.TabIndex = 18;
            this.lblTimeElapsed.Text = "End Time - Start Time";
            this.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculateTime
            // 
            this.btnCalculateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTime.Location = new System.Drawing.Point(3, 239);
            this.btnCalculateTime.Name = "btnCalculateTime";
            this.btnCalculateTime.Size = new System.Drawing.Size(146, 56);
            this.btnCalculateTime.TabIndex = 17;
            this.btnCalculateTime.Text = "Calculate Time";
            this.btnCalculateTime.UseVisualStyleBackColor = true;
            this.btnCalculateTime.Click += new System.EventHandler(this.btnCalculateTime_Click);
            // 
            // dtPickEnd
            // 
            this.dtPickEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPickEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickEnd.Location = new System.Drawing.Point(155, 180);
            this.dtPickEnd.Name = "dtPickEnd";
            this.dtPickEnd.Size = new System.Drawing.Size(277, 28);
            this.dtPickEnd.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(3, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 59);
            this.label8.TabIndex = 9;
            this.label8.Text = "END";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 59);
            this.label7.TabIndex = 8;
            this.label7.Text = "START";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeStarted
            // 
            this.lblTimeStarted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStarted.Location = new System.Drawing.Point(155, 59);
            this.lblTimeStarted.Name = "lblTimeStarted";
            this.lblTimeStarted.Size = new System.Drawing.Size(277, 59);
            this.lblTimeStarted.TabIndex = 3;
            this.lblTimeStarted.Text = "1/1/0001 12:00:00 AM";
            this.lblTimeStarted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Started";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Now";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.Location = new System.Drawing.Point(155, 0);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(277, 59);
            this.lblTimeNow.TabIndex = 12;
            this.lblTimeNow.Text = "1/1/0001 12:00:00 AM";
            this.lblTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtPickStart
            // 
            this.dtPickStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPickStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickStart.Location = new System.Drawing.Point(155, 121);
            this.dtPickStart.Name = "dtPickStart";
            this.dtPickStart.Size = new System.Drawing.Size(277, 28);
            this.dtPickStart.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCalculator,
            this.measurementConverterToolStripMenuItem,
            this.timeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 28);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemCalculator
            // 
            this.menuItemCalculator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.menuItemCalculator.Name = "menuItemCalculator";
            this.menuItemCalculator.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.menuItemCalculator.Size = new System.Drawing.Size(88, 24);
            this.menuItemCalculator.Text = "&Calculator";
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.regularToolStripMenuItem.Text = "&Standard";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.programmerToolStripMenuItem.Text = "&Programmer";
            // 
            // measurementConverterToolStripMenuItem
            // 
            this.measurementConverterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSCustomaryUnitsToolStripMenuItem,
            this.metricToolStripMenuItem});
            this.measurementConverterToolStripMenuItem.Name = "measurementConverterToolStripMenuItem";
            this.measurementConverterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.measurementConverterToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.measurementConverterToolStripMenuItem.Text = "&Measurement";
            // 
            // uSCustomaryUnitsToolStripMenuItem
            // 
            this.uSCustomaryUnitsToolStripMenuItem.Name = "uSCustomaryUnitsToolStripMenuItem";
            this.uSCustomaryUnitsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.U)));
            this.uSCustomaryUnitsToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.uSCustomaryUnitsToolStripMenuItem.Text = "&US Customary Units";
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.metricToolStripMenuItem.Text = "M&etric";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.timeToolStripMenuItem.Text = "&Time";
            // 
            // programTimer
            // 
            this.programTimer.Enabled = true;
            this.programTimer.Tick += new System.EventHandler(this.programTimer_Tick);
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 367);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Time";
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Time_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTimeStarted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCalculator;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurementConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSCustomaryUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtPickStart;
        private System.Windows.Forms.DateTimePicker dtPickEnd;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Button btnCalculateTime;
        private System.Windows.Forms.Timer programTimer;
    }
}