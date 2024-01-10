using System;

namespace MyCalender
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDays = new System.Windows.Forms.Label();
            this.DisplayEventLoop = new System.Windows.Forms.Timer(this.components);
            this.lbevent = new System.Windows.Forms.Label();
            this.contextMenuStrip_Day = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // lbDays
            // 
            this.lbDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(21, 22);
            this.lbDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(27, 20);
            this.lbDays.TabIndex = 0;
            this.lbDays.Text = "00";
            // 
            // DisplayEventLoop
            // 
            this.DisplayEventLoop.Enabled = true;
            this.DisplayEventLoop.Tick += new System.EventHandler(this.DisplayEventLoop_Tick);
            // 
            // lbevent
            // 
            this.lbevent.Location = new System.Drawing.Point(3, 98);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(222, 56);
            this.lbevent.TabIndex = 1;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip_Day
            // 
            this.contextMenuStrip_Day.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_Day.Name = "contextMenuStrip_Day";
            this.contextMenuStrip_Day.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip_Day.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Day_Opening);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ContextMenuStrip = this.contextMenuStrip_Day;
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.lbDays);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(225, 154);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        #endregion

        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Timer DisplayEventLoop;
        private System.Windows.Forms.Label lbevent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Day;
    }
}
