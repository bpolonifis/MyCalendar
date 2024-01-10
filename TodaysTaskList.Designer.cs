namespace MyCalender
{
    partial class TodaysTaskList
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
            this.TodaysTaskListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TodaysTaskListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TodaysTaskListDataGridView
            // 
            this.TodaysTaskListDataGridView.AllowUserToOrderColumns = true;
            this.TodaysTaskListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodaysTaskListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodaysTaskListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TodaysTaskListDataGridView.Name = "TodaysTaskListDataGridView";
            this.TodaysTaskListDataGridView.RowHeadersWidth = 62;
            this.TodaysTaskListDataGridView.RowTemplate.Height = 28;
            this.TodaysTaskListDataGridView.Size = new System.Drawing.Size(800, 450);
            this.TodaysTaskListDataGridView.TabIndex = 0;
            // 
            // TodaysTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TodaysTaskListDataGridView);
            this.Name = "TodaysTaskList";
            this.Text = "Today\'s Task List";
            ((System.ComponentModel.ISupportInitialize)(this.TodaysTaskListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TodaysTaskListDataGridView;
    }
}