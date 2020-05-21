namespace Reservations
{
    partial class updateConveyance
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.availableCB = new System.Windows.Forms.CheckBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.singleFareBox = new System.Windows.Forms.NumericUpDown();
            this.returnFareBox = new System.Windows.Forms.NumericUpDown();
            this.planeNumberBox = new System.Windows.Forms.TextBox();
            this.planeNumberLabel = new System.Windows.Forms.Label();
            this.updateConveyanceBtn = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.singleFareBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFareBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(218, 146);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(170, 22);
            this.nameBox.TabIndex = 0;
            // 
            // availableCB
            // 
            this.availableCB.AutoSize = true;
            this.availableCB.Checked = true;
            this.availableCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.availableCB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.availableCB.Location = new System.Drawing.Point(218, 384);
            this.availableCB.Name = "availableCB";
            this.availableCB.Size = new System.Drawing.Size(116, 26);
            this.availableCB.TabIndex = 3;
            this.availableCB.Text = "Available";
            this.availableCB.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(47, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 22);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label2.Location = new System.Drawing.Point(47, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Single Fare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label3.Location = new System.Drawing.Point(47, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return Fare";
            // 
            // singleFareBox
            // 
            this.singleFareBox.Location = new System.Drawing.Point(218, 271);
            this.singleFareBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.singleFareBox.Name = "singleFareBox";
            this.singleFareBox.Size = new System.Drawing.Size(170, 22);
            this.singleFareBox.TabIndex = 7;
            // 
            // returnFareBox
            // 
            this.returnFareBox.Location = new System.Drawing.Point(218, 329);
            this.returnFareBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.returnFareBox.Name = "returnFareBox";
            this.returnFareBox.Size = new System.Drawing.Size(170, 22);
            this.returnFareBox.TabIndex = 8;
            // 
            // planeNumberBox
            // 
            this.planeNumberBox.Location = new System.Drawing.Point(218, 214);
            this.planeNumberBox.Name = "planeNumberBox";
            this.planeNumberBox.Size = new System.Drawing.Size(170, 22);
            this.planeNumberBox.TabIndex = 9;
            // 
            // planeNumberLabel
            // 
            this.planeNumberLabel.AutoSize = true;
            this.planeNumberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.planeNumberLabel.Location = new System.Drawing.Point(47, 214);
            this.planeNumberLabel.Name = "planeNumberLabel";
            this.planeNumberLabel.Size = new System.Drawing.Size(139, 22);
            this.planeNumberLabel.TabIndex = 10;
            this.planeNumberLabel.Text = "Plane Number";
            // 
            // updateConveyanceBtn
            // 
            this.updateConveyanceBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateConveyanceBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateConveyanceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updateConveyanceBtn.Location = new System.Drawing.Point(234, 444);
            this.updateConveyanceBtn.Name = "updateConveyanceBtn";
            this.updateConveyanceBtn.Size = new System.Drawing.Size(170, 79);
            this.updateConveyanceBtn.TabIndex = 11;
            this.updateConveyanceBtn.Text = "Add";
            this.updateConveyanceBtn.UseVisualStyleBackColor = true;
            this.updateConveyanceBtn.Click += new System.EventHandler(this.ConveyanceBtn_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Underline);
            this.heading.Location = new System.Drawing.Point(21, 34);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(397, 44);
            this.heading.TabIndex = 12;
            this.heading.Text = "Update Conveyance";
            // 
            // resetBtn
            // 
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.resetBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(12, 455);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(161, 56);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Reset to Previous Details";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // updateConveyance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 546);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.updateConveyanceBtn);
            this.Controls.Add(this.planeNumberLabel);
            this.Controls.Add(this.planeNumberBox);
            this.Controls.Add(this.returnFareBox);
            this.Controls.Add(this.singleFareBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.availableCB);
            this.Controls.Add(this.nameBox);
            this.Name = "updateConveyance";
            this.Text = "updateConveyance";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addConveyance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.singleFareBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFareBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.CheckBox availableCB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown singleFareBox;
        private System.Windows.Forms.NumericUpDown returnFareBox;
        private System.Windows.Forms.TextBox planeNumberBox;
        private System.Windows.Forms.Label planeNumberLabel;
        private System.Windows.Forms.Button updateConveyanceBtn;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button resetBtn;
    }
}