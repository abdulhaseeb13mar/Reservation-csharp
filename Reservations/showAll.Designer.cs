namespace Reservations
{
    partial class showAll
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
            this.showAllBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPassengerCounter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trainPassengerCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.busPassengerCounter = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.planePassengerCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBtn
            // 
            this.showAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(460, 243);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(203, 75);
            this.showAllBtn.TabIndex = 0;
            this.showAllBtn.Text = "SHOW ALL";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 362);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL PASSENGERS";
            // 
            // totalPassengerCounter
            // 
            this.totalPassengerCounter.AutoSize = true;
            this.totalPassengerCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.totalPassengerCounter.Location = new System.Drawing.Point(753, 34);
            this.totalPassengerCounter.Name = "totalPassengerCounter";
            this.totalPassengerCounter.Size = new System.Drawing.Size(37, 39);
            this.totalPassengerCounter.TabIndex = 3;
            this.totalPassengerCounter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "TRAIN PASSENGERS";
            // 
            // trainPassengerCounter
            // 
            this.trainPassengerCounter.AutoSize = true;
            this.trainPassengerCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.trainPassengerCounter.Location = new System.Drawing.Point(262, 151);
            this.trainPassengerCounter.Name = "trainPassengerCounter";
            this.trainPassengerCounter.Size = new System.Drawing.Size(21, 24);
            this.trainPassengerCounter.TabIndex = 5;
            this.trainPassengerCounter.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(442, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "BUS PASSENGERS";
            // 
            // busPassengerCounter
            // 
            this.busPassengerCounter.AutoSize = true;
            this.busPassengerCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.busPassengerCounter.Location = new System.Drawing.Point(656, 151);
            this.busPassengerCounter.Name = "busPassengerCounter";
            this.busPassengerCounter.Size = new System.Drawing.Size(21, 24);
            this.busPassengerCounter.TabIndex = 7;
            this.busPassengerCounter.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(858, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "PLANE PASSENGERS";
            // 
            // planePassengerCounter
            // 
            this.planePassengerCounter.AutoSize = true;
            this.planePassengerCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.planePassengerCounter.Location = new System.Drawing.Point(1098, 151);
            this.planePassengerCounter.Name = "planePassengerCounter";
            this.planePassengerCounter.Size = new System.Drawing.Size(21, 24);
            this.planePassengerCounter.TabIndex = 9;
            this.planePassengerCounter.Text = "0";
            // 
            // showAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 697);
            this.Controls.Add(this.planePassengerCounter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.busPassengerCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trainPassengerCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPassengerCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showAllBtn);
            this.Name = "showAll";
            this.Text = "showAll";
            this.Load += new System.EventHandler(this.showAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPassengerCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trainPassengerCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label busPassengerCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label planePassengerCounter;
    }
}