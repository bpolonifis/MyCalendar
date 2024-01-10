namespace MyCalender
{
    partial class ArchieveList
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
            this.TaskListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TaskListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskListDataGridView
            // 
            this.TaskListDataGridView.AllowUserToOrderColumns = true;
            this.TaskListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TaskListDataGridView.Name = "TaskListDataGridView";
            this.TaskListDataGridView.RowHeadersWidth = 62;
            this.TaskListDataGridView.RowTemplate.Height = 28;
            this.TaskListDataGridView.Size = new System.Drawing.Size(1218, 755);
            this.TaskListDataGridView.TabIndex = 0;
            // 
            // ArchieveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 755);
            this.Controls.Add(this.TaskListDataGridView);
            this.Name = "ArchieveList";
            this.Text = "Archieve";
            this.Load += new System.EventHandler(this.ArchieveList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskListDataGridView;
    }
}