
namespace Store_Manager
{
    partial class Form1
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
            this.helpBtn = new System.Windows.Forms.Button();
            this.storeBtn = new System.Windows.Forms.Button();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.spiceBtn = new System.Windows.Forms.Button();
            this.meatBtn = new System.Windows.Forms.Button();
            this.vegetableBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.panelSelector);
            this.panel1.Controls.Add(this.storeBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 724);
            this.panel1.TabIndex = 0;
            // 
            // helpBtn
            // 
            this.helpBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpBtn.FlatAppearance.BorderSize = 2;
            this.helpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.helpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.Silver;
            this.helpBtn.Location = new System.Drawing.Point(0, 320);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.helpBtn.Size = new System.Drawing.Size(221, 56);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.storeBtn.FlatAppearance.BorderSize = 2;
            this.storeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.storeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.storeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeBtn.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBtn.ForeColor = System.Drawing.Color.Silver;
            this.storeBtn.Location = new System.Drawing.Point(0, 94);
            this.storeBtn.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.storeBtn.Size = new System.Drawing.Size(221, 56);
            this.storeBtn.TabIndex = 4;
            this.storeBtn.Text = "Store";
            this.storeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // panelSelector
            // 
            this.panelSelector.Controls.Add(this.spiceBtn);
            this.panelSelector.Controls.Add(this.meatBtn);
            this.panelSelector.Controls.Add(this.vegetableBtn);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelector.Location = new System.Drawing.Point(0, 150);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(221, 170);
            this.panelSelector.TabIndex = 5;
            // 
            // spiceBtn
            // 
            this.spiceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.spiceBtn.FlatAppearance.BorderSize = 0;
            this.spiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spiceBtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spiceBtn.ForeColor = System.Drawing.Color.Silver;
            this.spiceBtn.Location = new System.Drawing.Point(0, 112);
            this.spiceBtn.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.spiceBtn.Name = "spiceBtn";
            this.spiceBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.spiceBtn.Size = new System.Drawing.Size(221, 56);
            this.spiceBtn.TabIndex = 4;
            this.spiceBtn.Text = "Spice";
            this.spiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spiceBtn.UseVisualStyleBackColor = true;
            this.spiceBtn.Click += new System.EventHandler(this.spiceBtn_Click);
            // 
            // meatBtn
            // 
            this.meatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.meatBtn.FlatAppearance.BorderSize = 0;
            this.meatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.meatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.meatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meatBtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.meatBtn.ForeColor = System.Drawing.Color.Silver;
            this.meatBtn.Location = new System.Drawing.Point(0, 56);
            this.meatBtn.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.meatBtn.Name = "meatBtn";
            this.meatBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.meatBtn.Size = new System.Drawing.Size(221, 56);
            this.meatBtn.TabIndex = 3;
            this.meatBtn.Text = "Meat";
            this.meatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meatBtn.UseVisualStyleBackColor = true;
            this.meatBtn.Click += new System.EventHandler(this.meatBtn_Click);
            // 
            // vegetableBtn
            // 
            this.vegetableBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vegetableBtn.FlatAppearance.BorderSize = 0;
            this.vegetableBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.vegetableBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.vegetableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetableBtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.vegetableBtn.ForeColor = System.Drawing.Color.Silver;
            this.vegetableBtn.Location = new System.Drawing.Point(0, 0);
            this.vegetableBtn.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.vegetableBtn.Name = "vegetableBtn";
            this.vegetableBtn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.vegetableBtn.Size = new System.Drawing.Size(221, 56);
            this.vegetableBtn.TabIndex = 2;
            this.vegetableBtn.Text = "Vegetable";
            this.vegetableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vegetableBtn.UseVisualStyleBackColor = true;
            this.vegetableBtn.Click += new System.EventHandler(this.vegetableBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 94);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.panelChild.Location = new System.Drawing.Point(222, 0);
            this.panelChild.MinimumSize = new System.Drawing.Size(1114, 684);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1114, 724);
            this.panelChild.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1335, 724);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1114, 684);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Button spiceBtn;
        private System.Windows.Forms.Button meatBtn;
        private System.Windows.Forms.Button vegetableBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button helpBtn;
    }
}

