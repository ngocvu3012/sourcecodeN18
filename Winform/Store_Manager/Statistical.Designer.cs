
namespace Store_Manager
{
    partial class Statistical
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
            this.dataStatistical = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeStatistical = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataStatistical)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStatistical
            // 
            this.dataStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStatistical.Location = new System.Drawing.Point(128, 133);
            this.dataStatistical.Name = "dataStatistical";
            this.dataStatistical.RowHeadersWidth = 51;
            this.dataStatistical.RowTemplate.Height = 24;
            this.dataStatistical.Size = new System.Drawing.Size(837, 496);
            this.dataStatistical.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MTO Canun", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // dateTimeStatistical
            // 
            this.dateTimeStatistical.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStatistical.Location = new System.Drawing.Point(128, 86);
            this.dateTimeStatistical.Name = "dateTimeStatistical";
            this.dateTimeStatistical.Size = new System.Drawing.Size(444, 22);
            this.dateTimeStatistical.TabIndex = 2;
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1074, 664);
            this.Controls.Add(this.dateTimeStatistical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataStatistical);
            this.Name = "Statistical";
            this.Text = "Statistical";
            ((System.ComponentModel.ISupportInitialize)(this.dataStatistical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStatistical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeStatistical;
    }
}