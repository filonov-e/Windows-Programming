namespace Assignment7_1
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
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.searchFlightButton = new System.Windows.Forms.Button();
            this.modifyCustomerButton = new System.Windows.Forms.Button();
            this.modifyFlightButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.AutoSize = true;
            this.searchCustomerButton.Location = new System.Drawing.Point(56, 43);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(103, 23);
            this.searchCustomerButton.TabIndex = 0;
            this.searchCustomerButton.Text = "Search Customers";
            this.searchCustomerButton.UseVisualStyleBackColor = true;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // searchFlightButton
            // 
            this.searchFlightButton.AutoSize = true;
            this.searchFlightButton.Location = new System.Drawing.Point(63, 44);
            this.searchFlightButton.Name = "searchFlightButton";
            this.searchFlightButton.Size = new System.Drawing.Size(103, 23);
            this.searchFlightButton.TabIndex = 1;
            this.searchFlightButton.Text = "Search Flights";
            this.searchFlightButton.UseVisualStyleBackColor = true;
            this.searchFlightButton.Click += new System.EventHandler(this.searchFlightButton_Click);
            // 
            // modifyCustomerButton
            // 
            this.modifyCustomerButton.Location = new System.Drawing.Point(56, 73);
            this.modifyCustomerButton.Name = "modifyCustomerButton";
            this.modifyCustomerButton.Size = new System.Drawing.Size(103, 23);
            this.modifyCustomerButton.TabIndex = 2;
            this.modifyCustomerButton.Text = "Modify Customer";
            this.modifyCustomerButton.UseVisualStyleBackColor = true;
            this.modifyCustomerButton.Click += new System.EventHandler(this.modifyCustomerButton_Click);
            // 
            // modifyFlightButton
            // 
            this.modifyFlightButton.Location = new System.Drawing.Point(63, 73);
            this.modifyFlightButton.Name = "modifyFlightButton";
            this.modifyFlightButton.Size = new System.Drawing.Size(103, 23);
            this.modifyFlightButton.TabIndex = 3;
            this.modifyFlightButton.Text = "Modify Flight";
            this.modifyFlightButton.UseVisualStyleBackColor = true;
            this.modifyFlightButton.Click += new System.EventHandler(this.modifyFlightButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchCustomerButton);
            this.groupBox1.Controls.Add(this.modifyCustomerButton);
            this.groupBox1.Location = new System.Drawing.Point(123, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchFlightButton);
            this.groupBox2.Controls.Add(this.modifyFlightButton);
            this.groupBox2.Location = new System.Drawing.Point(410, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 129);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flights";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Button searchFlightButton;
        private System.Windows.Forms.Button modifyCustomerButton;
        private System.Windows.Forms.Button modifyFlightButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

