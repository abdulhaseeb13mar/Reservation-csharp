namespace Reservations
{
    partial class searchAndUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nameSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.numberSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.cnicSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.idGroupBox = new System.Windows.Forms.GroupBox();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.numberGroupBox = new System.Windows.Forms.GroupBox();
            this.cnicGroupBox = new System.Windows.Forms.GroupBox();
            this.idSearchRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.idGroupBox.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.numberGroupBox.SuspendLayout();
            this.cnicGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(45, 26);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 22);
            this.idBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(57, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(249, 22);
            this.nameBox.TabIndex = 5;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(123, 26);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(195, 22);
            this.phoneBox.TabIndex = 6;
            // 
            // cnicBox
            // 
            this.cnicBox.Location = new System.Drawing.Point(61, 26);
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(195, 22);
            this.cnicBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 422);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(520, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameSearchRadioButton
            // 
            this.nameSearchRadioButton.AutoSize = true;
            this.nameSearchRadioButton.Location = new System.Drawing.Point(311, 37);
            this.nameSearchRadioButton.Name = "nameSearchRadioButton";
            this.nameSearchRadioButton.Size = new System.Drawing.Size(135, 21);
            this.nameSearchRadioButton.TabIndex = 11;
            this.nameSearchRadioButton.TabStop = true;
            this.nameSearchRadioButton.Text = "Search By Name";
            this.nameSearchRadioButton.UseVisualStyleBackColor = true;
            this.nameSearchRadioButton.Click += new System.EventHandler(this.nameSearchRadioButton_Click);
            // 
            // numberSearchRadioButton
            // 
            this.numberSearchRadioButton.AutoSize = true;
            this.numberSearchRadioButton.Location = new System.Drawing.Point(672, 37);
            this.numberSearchRadioButton.Name = "numberSearchRadioButton";
            this.numberSearchRadioButton.Size = new System.Drawing.Size(192, 21);
            this.numberSearchRadioButton.TabIndex = 12;
            this.numberSearchRadioButton.TabStop = true;
            this.numberSearchRadioButton.Text = "Search by Phone Number";
            this.numberSearchRadioButton.UseVisualStyleBackColor = true;
            this.numberSearchRadioButton.Click += new System.EventHandler(this.numberSearchRadioButton_Click);
            // 
            // cnicSearchRadioButton
            // 
            this.cnicSearchRadioButton.AutoSize = true;
            this.cnicSearchRadioButton.Location = new System.Drawing.Point(1008, 37);
            this.cnicSearchRadioButton.Name = "cnicSearchRadioButton";
            this.cnicSearchRadioButton.Size = new System.Drawing.Size(128, 21);
            this.cnicSearchRadioButton.TabIndex = 13;
            this.cnicSearchRadioButton.TabStop = true;
            this.cnicSearchRadioButton.Text = "Search by CNIC";
            this.cnicSearchRadioButton.UseVisualStyleBackColor = true;
            this.cnicSearchRadioButton.Click += new System.EventHandler(this.cnicSearchRadioButton_Click);
            // 
            // idGroupBox
            // 
            this.idGroupBox.Controls.Add(this.idBox);
            this.idGroupBox.Controls.Add(this.label1);
            this.idGroupBox.Location = new System.Drawing.Point(13, 70);
            this.idGroupBox.Name = "idGroupBox";
            this.idGroupBox.Size = new System.Drawing.Size(175, 78);
            this.idGroupBox.TabIndex = 14;
            this.idGroupBox.TabStop = false;
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.nameBox);
            this.nameGroupBox.Controls.Add(this.label4);
            this.nameGroupBox.Location = new System.Drawing.Point(219, 70);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(334, 78);
            this.nameGroupBox.TabIndex = 15;
            this.nameGroupBox.TabStop = false;
            // 
            // numberGroupBox
            // 
            this.numberGroupBox.Controls.Add(this.phoneBox);
            this.numberGroupBox.Controls.Add(this.label3);
            this.numberGroupBox.Location = new System.Drawing.Point(570, 70);
            this.numberGroupBox.Name = "numberGroupBox";
            this.numberGroupBox.Size = new System.Drawing.Size(333, 78);
            this.numberGroupBox.TabIndex = 16;
            this.numberGroupBox.TabStop = false;
            // 
            // cnicGroupBox
            // 
            this.cnicGroupBox.Controls.Add(this.cnicBox);
            this.cnicGroupBox.Controls.Add(this.label2);
            this.cnicGroupBox.Location = new System.Drawing.Point(930, 70);
            this.cnicGroupBox.Name = "cnicGroupBox";
            this.cnicGroupBox.Size = new System.Drawing.Size(267, 77);
            this.cnicGroupBox.TabIndex = 17;
            this.cnicGroupBox.TabStop = false;
            // 
            // idSearchRadioButton
            // 
            this.idSearchRadioButton.AutoSize = true;
            this.idSearchRadioButton.Location = new System.Drawing.Point(34, 37);
            this.idSearchRadioButton.Name = "idSearchRadioButton";
            this.idSearchRadioButton.Size = new System.Drawing.Size(111, 21);
            this.idSearchRadioButton.TabIndex = 18;
            this.idSearchRadioButton.TabStop = true;
            this.idSearchRadioButton.Text = "Search By ID";
            this.idSearchRadioButton.UseVisualStyleBackColor = true;
            this.idSearchRadioButton.Click += new System.EventHandler(this.idSearchRadioButton_Click);
            // 
            // searchAndUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 712);
            this.Controls.Add(this.idSearchRadioButton);
            this.Controls.Add(this.cnicGroupBox);
            this.Controls.Add(this.numberGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.idGroupBox);
            this.Controls.Add(this.cnicSearchRadioButton);
            this.Controls.Add(this.numberSearchRadioButton);
            this.Controls.Add(this.nameSearchRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "searchAndUpdate";
            this.Text = "searchAndUpdate";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.idGroupBox.ResumeLayout(false);
            this.idGroupBox.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.numberGroupBox.ResumeLayout(false);
            this.numberGroupBox.PerformLayout();
            this.cnicGroupBox.ResumeLayout(false);
            this.cnicGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton nameSearchRadioButton;
        private System.Windows.Forms.RadioButton numberSearchRadioButton;
        private System.Windows.Forms.RadioButton cnicSearchRadioButton;
        private System.Windows.Forms.GroupBox idGroupBox;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.GroupBox numberGroupBox;
        private System.Windows.Forms.GroupBox cnicGroupBox;
        private System.Windows.Forms.RadioButton idSearchRadioButton;
    }
}