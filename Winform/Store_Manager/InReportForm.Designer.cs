
namespace Store_Manager
{
    partial class InReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectDataSet = new Store_Manager.ProjectDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataListTableAdapter = new Store_Manager.ProjectDataSetTableAdapters.dataListTableAdapter();
            this.printBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListBindingSource1
            // 
            this.dataListBindingSource1.DataMember = "dataList";
            this.dataListBindingSource1.DataSource = this.ProjectDataSet;
            // 
            // ProjectDataSet
            // 
            this.ProjectDataSet.DataSetName = "ProjectDataSet";
            this.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dataList";
            reportDataSource2.Value = this.dataListBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store_Manager.InReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1176, 751);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataListBindingSource
            // 
            this.dataListBindingSource.DataMember = "dataList";
            this.dataListBindingSource.DataSource = this.ProjectDataSet;
            // 
            // dataListTableAdapter
            // 
            this.dataListTableAdapter.ClearBeforeFill = true;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.printBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.printBtn.Location = new System.Drawing.Point(0, 700);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(1176, 51);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // InReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 751);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InReportForm";
            this.Text = "InReportForm";
            this.Load += new System.EventHandler(this.InReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataListBindingSource;
        private ProjectDataSet ProjectDataSet;
        private ProjectDataSetTableAdapters.dataListTableAdapter dataListTableAdapter;
        private System.Windows.Forms.BindingSource dataListBindingSource1;
        private System.Windows.Forms.Button printBtn;
    }
}