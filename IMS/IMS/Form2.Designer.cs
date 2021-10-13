namespace IMS
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.date = new System.Windows.Forms.GroupBox();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Button();
            this.filterby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IMS_DBDataSet = new IMS.IMS_DBDataSet();
            this.person_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_tblTableAdapter = new IMS.IMS_DBDataSetTableAdapters.person_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMS_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_tblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.date);
            this.splitContainer1.Panel1.Controls.Add(this.keyword);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.clear);
            this.splitContainer1.Panel1.Controls.Add(this.filter);
            this.splitContainer1.Panel1.Controls.Add(this.filterby);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1912, 963);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 1;
            // 
            // date
            // 
            this.date.Controls.Add(this.toDate);
            this.date.Controls.Add(this.label4);
            this.date.Controls.Add(this.fromDate);
            this.date.Controls.Add(this.label3);
            this.date.Location = new System.Drawing.Point(979, 3);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(613, 59);
            this.date.TabIndex = 7;
            this.date.TabStop = false;
            this.date.Text = "Date";
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(407, 18);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(166, 28);
            this.toDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "To:";
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(119, 20);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(166, 28);
            this.fromDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "From:";
            // 
            // keyword
            // 
            this.keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyword.Location = new System.Drawing.Point(469, 19);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(368, 28);
            this.keyword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Keyword:";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1799, 15);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 36);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(1698, 15);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(85, 36);
            this.filter.TabIndex = 2;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // filterby
            // 
            this.filterby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterby.FormattingEnabled = true;
            this.filterby.Items.AddRange(new object[] {
            "Keyword",
            "Date"});
            this.filterby.Location = new System.Drawing.Point(113, 19);
            this.filterby.Name = "filterby";
            this.filterby.Size = new System.Drawing.Size(121, 30);
            this.filterby.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.person_tblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IMS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1912, 884);
            this.reportViewer1.TabIndex = 0;
            // 
            // IMS_DBDataSet
            // 
            this.IMS_DBDataSet.DataSetName = "IMS_DBDataSet";
            this.IMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // person_tblBindingSource
            // 
            this.person_tblBindingSource.DataMember = "person_tbl";
            this.person_tblBindingSource.DataSource = this.IMS_DBDataSet;
            // 
            // person_tblTableAdapter
            // 
            this.person_tblTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 963);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghana Immigration Service - Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.date.ResumeLayout(false);
            this.date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMS_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_tblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox date;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.ComboBox filterby;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource person_tblBindingSource;
        private IMS_DBDataSet IMS_DBDataSet;
        private IMS_DBDataSetTableAdapters.person_tblTableAdapter person_tblTableAdapter;

    }
}