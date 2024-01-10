namespace MyCalender
{
    partial class MonthlyCalender
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.LBDATE = new System.Windows.Forms.Label();
            this.contextMenuStrip_Calendar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goToDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brainDumpListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archieveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Calendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(4, 78);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1640, 945);
            this.daycontainer.TabIndex = 0;
            this.daycontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.daycontainer_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1245, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1467, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Saturday";
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(1373, 1033);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(112, 35);
            this.btnprevious.TabIndex = 8;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(1494, 1033);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(112, 35);
            this.btnnext.TabIndex = 9;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // LBDATE
            // 
            this.LBDATE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDATE.Location = new System.Drawing.Point(495, -2);
            this.LBDATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(518, 54);
            this.LBDATE.TabIndex = 10;
            this.LBDATE.Text = "Month & Year";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip_Calendar
            // 
            this.contextMenuStrip_Calendar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_Calendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToDayToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.currentMonthToolStripMenuItem,
            this.nextMonthToolStripMenuItem,
            this.previousMonthToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip_Calendar.Name = "contextMenuStrip_Calendar";
            this.contextMenuStrip_Calendar.Size = new System.Drawing.Size(241, 261);
            // 
            // goToDayToolStripMenuItem
            // 
            this.goToDayToolStripMenuItem.Name = "goToDayToolStripMenuItem";
            this.goToDayToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.goToDayToolStripMenuItem.Text = "Today\'s Task List";
            this.goToDayToolStripMenuItem.Click += new System.EventHandler(this.todaysTaskListToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brainDumpListToolStripMenuItem1,
            this.archieveListToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // brainDumpListToolStripMenuItem1
            // 
            this.brainDumpListToolStripMenuItem1.Name = "brainDumpListToolStripMenuItem1";
            this.brainDumpListToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.brainDumpListToolStripMenuItem1.Text = "BrainDump List";
            this.brainDumpListToolStripMenuItem1.Click += new System.EventHandler(this.brainDumpListToolStripMenuItem1_Click);
            // 
            // archieveListToolStripMenuItem
            // 
            this.archieveListToolStripMenuItem.Name = "archieveListToolStripMenuItem";
            this.archieveListToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.archieveListToolStripMenuItem.Text = "Archieve List";
            this.archieveListToolStripMenuItem.Click += new System.EventHandler(this.archieveListToolStripMenuItem_Click);
            // 
            // currentMonthToolStripMenuItem
            // 
            this.currentMonthToolStripMenuItem.Name = "currentMonthToolStripMenuItem";
            this.currentMonthToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.currentMonthToolStripMenuItem.Text = "Current Month";
            this.currentMonthToolStripMenuItem.Click += new System.EventHandler(this.currentMonthToolStripMenuItem_Click);
            // 
            // nextMonthToolStripMenuItem
            // 
            this.nextMonthToolStripMenuItem.Name = "nextMonthToolStripMenuItem";
            this.nextMonthToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.nextMonthToolStripMenuItem.Text = "Next Month";
            this.nextMonthToolStripMenuItem.Click += new System.EventHandler(this.nextMonthToolStripMenuItem_Click);
            // 
            // previousMonthToolStripMenuItem
            // 
            this.previousMonthToolStripMenuItem.Name = "previousMonthToolStripMenuItem";
            this.previousMonthToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.previousMonthToolStripMenuItem.Text = "Previous Month";
            this.previousMonthToolStripMenuItem.Click += new System.EventHandler(this.previousMonthToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.daToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // daToolStripMenuItem
            // 
            this.daToolStripMenuItem.Name = "daToolStripMenuItem";
            this.daToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.daToolStripMenuItem.Text = "Text";
            this.daToolStripMenuItem.Click += new System.EventHandler(this.daToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MonthlyCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1650, 1141);
            this.ContextMenuStrip = this.contextMenuStrip_Calendar;
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daycontainer);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonthlyCalender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip_Calendar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label LBDATE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Calendar;
        private System.Windows.Forms.ToolStripMenuItem nextMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brainDumpListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem archieveListToolStripMenuItem;
    }
}

