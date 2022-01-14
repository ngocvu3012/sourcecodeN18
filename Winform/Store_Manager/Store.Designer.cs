
namespace Store_Manager
{
    partial class Store
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.conBtn = new System.Windows.Forms.Button();
            this.valueDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.valuePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valueNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valueUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.welLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statisticalBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.wareBtn = new System.Windows.Forms.Button();
            this.deleBtn = new System.Windows.Forms.Button();
            this.receiptBtn = new System.Windows.Forms.Button();
            this.storeData = new System.Windows.Forms.DataGridView();
            this.tittleData = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.tittle = new System.Windows.Forms.Label();
            this.panelStatistical = new System.Windows.Forms.Panel();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSelector.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.panelSelector);
            this.panel1.Controls.Add(this.welLable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 916);
            this.panel1.TabIndex = 1;
            // 
            // panelSelector
            // 
            this.panelSelector.AutoScroll = true;
            this.panelSelector.Controls.Add(this.employeeName);
            this.panelSelector.Controls.Add(this.label7);
            this.panelSelector.Controls.Add(this.cancleBtn);
            this.panelSelector.Controls.Add(this.conBtn);
            this.panelSelector.Controls.Add(this.valueDate);
            this.panelSelector.Controls.Add(this.label6);
            this.panelSelector.Controls.Add(this.valuePrice);
            this.panelSelector.Controls.Add(this.label5);
            this.panelSelector.Controls.Add(this.valueNumber);
            this.panelSelector.Controls.Add(this.label4);
            this.panelSelector.Controls.Add(this.valueUnit);
            this.panelSelector.Controls.Add(this.label3);
            this.panelSelector.Controls.Add(this.valueID);
            this.panelSelector.Controls.Add(this.label2);
            this.panelSelector.Controls.Add(this.valueName);
            this.panelSelector.Controls.Add(this.label1);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelector.Location = new System.Drawing.Point(0, 126);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(420, 790);
            this.panelSelector.TabIndex = 2;
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.Red;
            this.cancleBtn.FlatAppearance.BorderSize = 0;
            this.cancleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.cancleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancleBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Italic);
            this.cancleBtn.ForeColor = System.Drawing.Color.Yellow;
            this.cancleBtn.Location = new System.Drawing.Point(202, 657);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(181, 93);
            this.cancleBtn.TabIndex = 16;
            this.cancleBtn.Text = "Cancle";
            this.cancleBtn.UseVisualStyleBackColor = false;
            // 
            // conBtn
            // 
            this.conBtn.BackColor = System.Drawing.Color.Lime;
            this.conBtn.FlatAppearance.BorderSize = 0;
            this.conBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.conBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.conBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Italic);
            this.conBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.conBtn.Location = new System.Drawing.Point(15, 657);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(181, 93);
            this.conBtn.TabIndex = 15;
            this.conBtn.Text = "Confirm";
            this.conBtn.UseVisualStyleBackColor = false;
            // 
            // valueDate
            // 
            this.valueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueDate.Location = new System.Drawing.Point(18, 537);
            this.valueDate.Name = "valueDate";
            this.valueDate.Size = new System.Drawing.Size(387, 30);
            this.valueDate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(13, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date:";
            // 
            // valuePrice
            // 
            this.valuePrice.BackColor = System.Drawing.SystemColors.Window;
            this.valuePrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.valuePrice.Location = new System.Drawing.Point(17, 370);
            this.valuePrice.Multiline = true;
            this.valuePrice.Name = "valuePrice";
            this.valuePrice.Size = new System.Drawing.Size(387, 37);
            this.valuePrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price:";
            // 
            // valueNumber
            // 
            this.valueNumber.BackColor = System.Drawing.SystemColors.Window;
            this.valueNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.valueNumber.Location = new System.Drawing.Point(17, 291);
            this.valueNumber.Multiline = true;
            this.valueNumber.Name = "valueNumber";
            this.valueNumber.Size = new System.Drawing.Size(387, 37);
            this.valueNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of value:";
            // 
            // valueUnit
            // 
            this.valueUnit.BackColor = System.Drawing.SystemColors.Window;
            this.valueUnit.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.valueUnit.Location = new System.Drawing.Point(17, 213);
            this.valueUnit.Multiline = true;
            this.valueUnit.Name = "valueUnit";
            this.valueUnit.Size = new System.Drawing.Size(387, 37);
            this.valueUnit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value\'s unit:";
            // 
            // valueID
            // 
            this.valueID.BackColor = System.Drawing.SystemColors.Window;
            this.valueID.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.valueID.Location = new System.Drawing.Point(17, 126);
            this.valueID.Multiline = true;
            this.valueID.Name = "valueID";
            this.valueID.Size = new System.Drawing.Size(387, 37);
            this.valueID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value\'s ID:";
            // 
            // valueName
            // 
            this.valueName.BackColor = System.Drawing.SystemColors.Window;
            this.valueName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.valueName.Location = new System.Drawing.Point(17, 45);
            this.valueName.Multiline = true;
            this.valueName.Name = "valueName";
            this.valueName.Size = new System.Drawing.Size(387, 37);
            this.valueName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value\'s name:";
            // 
            // welLable
            // 
            this.welLable.AutoSize = true;
            this.welLable.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welLable.ForeColor = System.Drawing.Color.Yellow;
            this.welLable.Location = new System.Drawing.Point(29, 305);
            this.welLable.Name = "welLable";
            this.welLable.Size = new System.Drawing.Size(324, 97);
            this.welLable.TabIndex = 1;
            this.welLable.Text = "Welcome!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statisticalBtn);
            this.panel2.Controls.Add(this.exportBtn);
            this.panel2.Controls.Add(this.wareBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 126);
            this.panel2.TabIndex = 0;
            // 
            // statisticalBtn
            // 
            this.statisticalBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.statisticalBtn.FlatAppearance.BorderSize = 0;
            this.statisticalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(35)))));
            this.statisticalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.statisticalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticalBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticalBtn.ForeColor = System.Drawing.Color.Yellow;
            this.statisticalBtn.Location = new System.Drawing.Point(264, 0);
            this.statisticalBtn.Name = "statisticalBtn";
            this.statisticalBtn.Size = new System.Drawing.Size(153, 126);
            this.statisticalBtn.TabIndex = 2;
            this.statisticalBtn.Text = "Statistical ";
            this.statisticalBtn.UseVisualStyleBackColor = true;
            this.statisticalBtn.Click += new System.EventHandler(this.statisticalBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(35)))));
            this.exportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.Yellow;
            this.exportBtn.Location = new System.Drawing.Point(132, 0);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(132, 126);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Out put";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // wareBtn
            // 
            this.wareBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.wareBtn.FlatAppearance.BorderSize = 0;
            this.wareBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(35)))));
            this.wareBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(89)))), ((int)(((byte)(82)))));
            this.wareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wareBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wareBtn.ForeColor = System.Drawing.Color.Yellow;
            this.wareBtn.Location = new System.Drawing.Point(0, 0);
            this.wareBtn.Name = "wareBtn";
            this.wareBtn.Size = new System.Drawing.Size(132, 126);
            this.wareBtn.TabIndex = 0;
            this.wareBtn.Text = "In put";
            this.wareBtn.UseVisualStyleBackColor = true;
            this.wareBtn.Click += new System.EventHandler(this.wareBtn_Click);
            // 
            // deleBtn
            // 
            this.deleBtn.BackColor = System.Drawing.Color.Silver;
            this.deleBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleBtn.FlatAppearance.BorderSize = 5;
            this.deleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Italic);
            this.deleBtn.ForeColor = System.Drawing.Color.Black;
            this.deleBtn.Location = new System.Drawing.Point(682, 663);
            this.deleBtn.Name = "deleBtn";
            this.deleBtn.Size = new System.Drawing.Size(181, 93);
            this.deleBtn.TabIndex = 24;
            this.deleBtn.Text = "Delete";
            this.deleBtn.UseVisualStyleBackColor = false;
            this.deleBtn.Click += new System.EventHandler(this.deleBtn_Click);
            // 
            // receiptBtn
            // 
            this.receiptBtn.BackColor = System.Drawing.Color.Silver;
            this.receiptBtn.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.receiptBtn.FlatAppearance.BorderSize = 5;
            this.receiptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.receiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Italic);
            this.receiptBtn.ForeColor = System.Drawing.Color.Black;
            this.receiptBtn.Location = new System.Drawing.Point(897, 663);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(181, 93);
            this.receiptBtn.TabIndex = 23;
            this.receiptBtn.Text = "Receipt";
            this.receiptBtn.UseVisualStyleBackColor = false;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // storeData
            // 
            this.storeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeData.Location = new System.Drawing.Point(1156, 92);
            this.storeData.Name = "storeData";
            this.storeData.RowHeadersWidth = 51;
            this.storeData.RowTemplate.Height = 24;
            this.storeData.Size = new System.Drawing.Size(720, 548);
            this.storeData.TabIndex = 22;
            // 
            // tittleData
            // 
            this.tittleData.AutoSize = true;
            this.tittleData.Font = new System.Drawing.Font("MTO augie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleData.ForeColor = System.Drawing.Color.Yellow;
            this.tittleData.Location = new System.Drawing.Point(1084, 39);
            this.tittleData.Name = "tittleData";
            this.tittleData.Size = new System.Drawing.Size(224, 50);
            this.tittleData.TabIndex = 21;
            this.tittleData.Text = "Store data:";
            // 
            // dataList
            // 
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Location = new System.Drawing.Point(442, 92);
            this.dataList.Name = "dataList";
            this.dataList.RowHeadersWidth = 51;
            this.dataList.RowTemplate.Height = 24;
            this.dataList.Size = new System.Drawing.Size(636, 548);
            this.dataList.TabIndex = 20;
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("MTO augie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.Yellow;
            this.tittle.Location = new System.Drawing.Point(433, 30);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(198, 50);
            this.tittle.TabIndex = 19;
            this.tittle.Text = "Set tittle";
            // 
            // panelStatistical
            // 
            this.panelStatistical.Location = new System.Drawing.Point(548, 12);
            this.panelStatistical.Name = "panelStatistical";
            this.panelStatistical.Size = new System.Drawing.Size(857, 458);
            this.panelStatistical.TabIndex = 25;
            // 
            // employeeName
            // 
            this.employeeName.BackColor = System.Drawing.SystemColors.Window;
            this.employeeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F);
            this.employeeName.Location = new System.Drawing.Point(15, 453);
            this.employeeName.Multiline = true;
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(387, 37);
            this.employeeName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(10, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Employee:";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1891, 916);
            this.Controls.Add(this.panelStatistical);
            this.Controls.Add(this.deleBtn);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.storeData);
            this.Controls.Add(this.tittleData);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.panel1);
            this.Name = "Store";
            this.Text = "Store";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSelector.ResumeLayout(false);
            this.panelSelector.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.DateTimePicker valueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valuePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valueNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valueUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welLable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button statisticalBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button wareBtn;
        private System.Windows.Forms.Button deleBtn;
        private System.Windows.Forms.Button receiptBtn;
        private System.Windows.Forms.DataGridView storeData;
        private System.Windows.Forms.Label tittleData;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Panel panelStatistical;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label7;
    }
}