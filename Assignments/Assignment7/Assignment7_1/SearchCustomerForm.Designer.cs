namespace Assignment7_1
{
    partial class SearchCustomerForm
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchCustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCustomerFlightDataGridView = new System.Windows.Forms.DataGridView();
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.searchCustomerFlightLabel = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearCustomerSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerFlightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 42);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // searchCustomerDataGridView
            // 
            this.searchCustomerDataGridView.AllowUserToAddRows = false;
            this.searchCustomerDataGridView.AllowUserToDeleteRows = false;
            this.searchCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCustomerDataGridView.Location = new System.Drawing.Point(15, 106);
            this.searchCustomerDataGridView.Name = "searchCustomerDataGridView";
            this.searchCustomerDataGridView.ReadOnly = true;
            this.searchCustomerDataGridView.Size = new System.Drawing.Size(363, 332);
            this.searchCustomerDataGridView.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(59, 39);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(165, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchCustomerFlightDataGridView
            // 
            this.searchCustomerFlightDataGridView.AllowUserToAddRows = false;
            this.searchCustomerFlightDataGridView.AllowUserToDeleteRows = false;
            this.searchCustomerFlightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCustomerFlightDataGridView.Location = new System.Drawing.Point(384, 106);
            this.searchCustomerFlightDataGridView.Name = "searchCustomerFlightDataGridView";
            this.searchCustomerFlightDataGridView.ReadOnly = true;
            this.searchCustomerFlightDataGridView.Size = new System.Drawing.Size(561, 332);
            this.searchCustomerFlightDataGridView.TabIndex = 4;
            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Location = new System.Drawing.Point(12, 90);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(56, 13);
            this.searchCustomerLabel.TabIndex = 5;
            this.searchCustomerLabel.Text = "Customers";
            // 
            // searchCustomerFlightLabel
            // 
            this.searchCustomerFlightLabel.AutoSize = true;
            this.searchCustomerFlightLabel.Location = new System.Drawing.Point(381, 90);
            this.searchCustomerFlightLabel.Name = "searchCustomerFlightLabel";
            this.searchCustomerFlightLabel.Size = new System.Drawing.Size(37, 13);
            this.searchCustomerFlightLabel.TabIndex = 6;
            this.searchCustomerFlightLabel.Text = "Flights";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Assignment7_1.Customer);
            // 
            // clearCustomerSearchButton
            // 
            this.clearCustomerSearchButton.Location = new System.Drawing.Point(246, 37);
            this.clearCustomerSearchButton.Name = "clearCustomerSearchButton";
            this.clearCustomerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.clearCustomerSearchButton.TabIndex = 7;
            this.clearCustomerSearchButton.Text = "Clear";
            this.clearCustomerSearchButton.UseVisualStyleBackColor = true;
            this.clearCustomerSearchButton.Click += new System.EventHandler(this.clearCustomerSearchButton_Click);
            // 
            // SearchCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.clearCustomerSearchButton);
            this.Controls.Add(this.searchCustomerFlightLabel);
            this.Controls.Add(this.searchCustomerLabel);
            this.Controls.Add(this.searchCustomerFlightDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchCustomerDataGridView);
            this.Controls.Add(this.searchLabel);
            this.Name = "SearchCustomerForm";
            this.Text = "SearchCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCustomerFlightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView searchCustomerDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchCustomerFlightDataGridView;
        private System.Windows.Forms.Label searchCustomerLabel;
        private System.Windows.Forms.Label searchCustomerFlightLabel;
        private System.Windows.Forms.Button clearCustomerSearchButton;
    }
}