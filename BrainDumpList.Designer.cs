namespace MyCalender
{
    partial class BrainDumpList
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
            this.BrainDumpListdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BrainDumpListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BrainDumpListdataGridView
            // 
            this.BrainDumpListdataGridView.AllowUserToOrderColumns = true;
            this.BrainDumpListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrainDumpListdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrainDumpListdataGridView.Location = new System.Drawing.Point(0, 0);
            this.BrainDumpListdataGridView.Name = "BrainDumpListdataGridView";
            this.BrainDumpListdataGridView.RowHeadersWidth = 62;
            this.BrainDumpListdataGridView.RowTemplate.Height = 28;
            this.BrainDumpListdataGridView.Size = new System.Drawing.Size(800, 450);
            this.BrainDumpListdataGridView.TabIndex = 0;
            // 
            // BrainDumpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrainDumpListdataGridView);
            this.Name = "BrainDumpList";
            this.Text = "BrainDump List";
            this.Load += new System.EventHandler(this.BrainDumpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrainDumpListdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BrainDumpListdataGridView;
    }
}