namespace Reservations
{
    partial class addConveyance
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
            this.addConveyanceBtn = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.singleFareBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnFareBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(185, 146);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 22);
            this.nameBox.TabIndex = 0;
            // 
            // availableCB
            // 
            this.availableCB.AutoSize = true;
            this.availableCB.Checked = true;
            this.availableCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.availableCB.Location = new System.Drawing.Point(185, 391);
            this.availableCB.Name = "availableCB";
            this.availableCB.Size = new System.Drawing.Size(87, 21);
            this.availableCB.TabIndex = 3;
            this.availableCB.Text = "Available";
            this.availableCB.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(47, 151);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Single Fare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return Fare";
            // 
            // singleFareBox
            // 
            this.singleFareBox.Location = new System.Drawing.Point(185, 274);
            this.singleFareBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.singleFareBox.Name = "singleFareBox";
            this.singleFareBox.Size = new System.Drawing.Size(120, 22);
            this.singleFareBox.TabIndex = 7;
            // 
            // returnFareBox
            // 
            this.returnFareBox.Location = new System.Drawing.Point(185, 329);
            this.returnFareBox.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.returnFareBox.Name = "returnFareBox";
            this.returnFareBox.Size = new System.Drawing.Size(120, 22);
            this.returnFareBox.TabIndex = 8;
            // 
            // planeNumberBox
            // 
            this.planeNumberBox.Location = new System.Drawing.Point(185, 214);
            this.planeNumberBox.Name = "planeNumberBox";
            this.planeNumberBox.Size = new System.Drawing.Size(120, 22);
            this.planeNumberBox.TabIndex = 9;
            // 
            // planeNumberLabel
            // 
            this.planeNumberLabel.AutoSize = true;
            this.planeNumberLabel.Location = new System.Drawing.Point(47, 217);
            this.planeNumberLabel.Name = "planeNumberLabel";
            this.planeNumberLabel.Size = new System.Drawing.Size(98, 17);
            this.planeNumberLabel.TabIndex = 10;
            this.planeNumberLabel.Text = "Plane Number";
            // 
            // addConveyanceBtn
            // 
            this.addConveyanceBtn.Font = new System.Drawing.Font("Adobe Gothic Std B", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addConveyanceBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.addConveyanceBtn.Location = new System.Drawing.Point(63, 442);
            this.addConveyanceBtn.Name = "addConveyanceBtn";
            this.addConveyanceBtn.Size = new System.Drawing.Size(170, 79);
            this.addConveyanceBtn.TabIndex = 11;
            this.addConveyanceBtn.Text = "ADD";
            this.addConveyanceBtn.UseVisualStyleBackColor = true;
            this.addConveyanceBtn.Click += new System.EventHandler(this.addConveyanceBtn_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(57, 42);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(230, 35);
            this.heading.TabIndex = 12;
            this.heading.Text = "Add Conveyance";
            // 
            // addConveyance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 546);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.addConveyanceBtn);
            this.Controls.Add(this.planeNumberLabel);
            this.Controls.Add(this.planeNumberBox);
            this.Controls.Add(this.returnFareBox);
            this.Controls.Add(this.singleFareBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.availableCB);
            this.Controls.Add(this.nameBox);
            this.Name = "addConveyance";
            this.Text = "Add Conveyance";
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
        private System.Windows.Forms.Button addConveyanceBtn;
        private System.Windows.Forms.Label heading;
    }
}