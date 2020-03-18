namespace Assignment8_1
{
    partial class SearchFlightForm
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
            this.searchCustomerFlightLabel = new System.Windows.Forms.Label();
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.searchFlightCustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchFlightDataGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.clearFlightSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchFlightCustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchFlightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCustomerFlightLabel
            // 
            this.searchCustomerFlightLabel.AutoSize = true;
            this.searchCustomerFlightLabel.Location = new System.Drawing.Point(49, 124);
            this.searchCustomerFlightLabel.Name = "searchCustomerFlightLabel";
            this.searchCustomerFlightLabel.Size = new System.Drawing.Size(37, 13);
            this.searchCustomerFlightLabel.TabIndex = 13;
            this.searchCustomerFlightLabel.Text = "Flights";
            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Location = new System.Drawing.Point(621, 124);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(56, 13);
            this.searchCustomerLabel.TabIndex = 12;
            this.searchCustomerLabel.Text = "Customers";
            // 
            // searchFlightCustomerDataGridView
            // 
            this.searchFlightCustomerDataGridView.AllowUserToAddRows = false;
            this.searchFlightCustomerDataGridView.AllowUserToDeleteRows = false;
            this.searchFlightCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchFlightCustomerDataGridView.Location = new System.Drawing.Point(624, 140);
            this.searchFlightCustomerDataGridView.Name = "searchFlightCustomerDataGridView";
            this.searchFlightCustomerDataGridView.ReadOnly = true;
            this.searchFlightCustomerDataGridView.Size = new System.Drawing.Size(358, 332);
            this.searchFlightCustomerDataGridView.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(202, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(96, 73);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 9;
            // 
            // searchFlightDataGridView
            // 
            this.searchFlightDataGridView.AllowUserToAddRows = false;
            this.searchFlightDataGridView.AllowUserToDeleteRows = false;
            this.searchFlightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchFlightDataGridView.Location = new System.Drawing.Point(52, 140);
            this.searchFlightDataGridView.Name = "searchFlightDataGridView";
            this.searchFlightDataGridView.ReadOnly = true;
            this.searchFlightDataGridView.Size = new System.Drawing.Size(566, 332);
            this.searchFlightDataGridView.TabIndex = 8;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(49, 76);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search";
            // 
            // clearFlightSearchButton
            // 
            this.clearFlightSearchButton.Location = new System.Drawing.Point(283, 71);
            this.clearFlightSearchButton.Name = "clearFlightSearchButton";
            this.clearFlightSearchButton.Size = new System.Drawing.Size(75, 23);
            this.clearFlightSearchButton.TabIndex = 14;
            this.clearFlightSearchButton.Text = "Clear";
            this.clearFlightSearchButton.UseVisualStyleBackColor = true;
            this.clearFlightSearchButton.Click += new System.EventHandler(this.clearFlightSearchButton_Click);
            // 
            // SearchFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 542);
            this.Controls.Add(this.clearFlightSearchButton);
            this.Controls.Add(this.searchCustomerFlightLabel);
            this.Controls.Add(this.searchCustomerLabel);
            this.Controls.Add(this.searchFlightCustomerDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchFlightDataGridView);
            this.Controls.Add(this.searchLabel);
            this.Name = "SearchFlightForm";
            this.Text = "SearchFlightForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchFlightCustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchFlightDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchCustomerFlightLabel;
        private System.Windows.Forms.Label searchCustomerLabel;
        private System.Windows.Forms.DataGridView searchFlightCustomerDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView searchFlightDataGridView;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button clearFlightSearchButton;
    }
}