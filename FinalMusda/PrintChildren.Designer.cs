namespace FinalMusda
{
    partial class PrintChildren
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CMSDataSet = new FinalMusda.CMSDataSet();
            this.AddChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddChildTableAdapter = new FinalMusda.CMSDataSetTableAdapters.AddChildTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddChildBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AddChildBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalMusda.ChildrenDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // CMSDataSet
            // 
            this.CMSDataSet.DataSetName = "CMSDataSet";
            this.CMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddChildBindingSource
            // 
            this.AddChildBindingSource.DataMember = "AddChild";
            this.AddChildBindingSource.DataSource = this.CMSDataSet;
            // 
            // AddChildTableAdapter
            // 
            this.AddChildTableAdapter.ClearBeforeFill = true;
            // 
            // PrintChildren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintChildren";
            this.Load += new System.EventHandler(this.PrintChildren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddChildBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AddChildBindingSource;
        private CMSDataSet CMSDataSet;
        private CMSDataSetTableAdapters.AddChildTableAdapter AddChildTableAdapter;
    }
}