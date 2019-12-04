namespace MovieTheaterApplication
{
    partial class EditShowingsForm
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
            this.uxEditTypesBox = new System.Windows.Forms.ComboBox();
            this.uxEditOptionsLabel = new System.Windows.Forms.Label();
            this.uxTitleSearchBox = new System.Windows.Forms.TextBox();
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.uxCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxCustomerAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxMovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxShowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.uxShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxTitleSearchLabel = new System.Windows.Forms.Label();
            this.uxShowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxShowDateLabel = new System.Windows.Forms.Label();
            this.uxShowTimeLabel = new System.Windows.Forms.Label();
            this.uxShowTimesBox = new System.Windows.Forms.ComboBox();
            this.uxSearchOptionsBox = new System.Windows.Forms.ComboBox();
            this.uxSearchOptionsLabel = new System.Windows.Forms.Label();
            this.uxCustomerNameLabel = new System.Windows.Forms.Label();
            this.uxCustomerNameBox = new System.Windows.Forms.TextBox();
            this.uxCustomerTypeLabel = new System.Windows.Forms.Label();
            this.uxCustomerTypeBox = new System.Windows.Forms.ComboBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxExecuteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // uxEditTypesBox
            // 
            this.uxEditTypesBox.FormattingEnabled = true;
            this.uxEditTypesBox.Items.AddRange(new object[] {
            "Add Viewing",
            "Modify Viewing",
            "Delete Viewing"});
            this.uxEditTypesBox.Location = new System.Drawing.Point(110, 12);
            this.uxEditTypesBox.Name = "uxEditTypesBox";
            this.uxEditTypesBox.Size = new System.Drawing.Size(121, 24);
            this.uxEditTypesBox.TabIndex = 2;
            // 
            // uxEditOptionsLabel
            // 
            this.uxEditOptionsLabel.AutoSize = true;
            this.uxEditOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEditOptionsLabel.Location = new System.Drawing.Point(12, 14);
            this.uxEditOptionsLabel.Name = "uxEditOptionsLabel";
            this.uxEditOptionsLabel.Size = new System.Drawing.Size(84, 20);
            this.uxEditOptionsLabel.TabIndex = 7;
            this.uxEditOptionsLabel.Text = "Edit Type:";
            // 
            // uxTitleSearchBox
            // 
            this.uxTitleSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleSearchBox.Location = new System.Drawing.Point(170, 97);
            this.uxTitleSearchBox.Name = "uxTitleSearchBox";
            this.uxTitleSearchBox.Size = new System.Drawing.Size(299, 26);
            this.uxTitleSearchBox.TabIndex = 8;
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxCustomerName,
            this.uxCustomerAge,
            this.uxMovieTitle,
            this.uxShowDate});
            this.uxMovieEntries.Location = new System.Drawing.Point(16, 290);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(685, 205);
            this.uxMovieEntries.TabIndex = 9;
            // 
            // uxCustomerName
            // 
            this.uxCustomerName.HeaderText = "Customer Name";
            this.uxCustomerName.MinimumWidth = 6;
            this.uxCustomerName.Name = "uxCustomerName";
            this.uxCustomerName.Width = 125;
            this.uxCustomerName.DataPropertyName = "CustomerName";
            // 
            // uxCustomerAge
            // 
            this.uxCustomerAge.HeaderText = "Customer Type";
            this.uxCustomerAge.MinimumWidth = 6;
            this.uxCustomerAge.Name = "uxCustomerAge";
            this.uxCustomerAge.Width = 125;
            this.uxCustomerAge.DataPropertyName = "CustomerCategory";
            // 
            // uxMovieTitle
            // 
            this.uxMovieTitle.HeaderText = "Movie Title";
            this.uxMovieTitle.MinimumWidth = 6;
            this.uxMovieTitle.Name = "uxMovieTitle";
            this.uxMovieTitle.Width = 125;
            this.uxMovieTitle.DataPropertyName = "MovieTitle";
            // 
            // uxShowDate
            // 
            this.uxShowDate.HeaderText = "Show Date";
            this.uxShowDate.MinimumWidth = 6;
            this.uxShowDate.Name = "uxShowDate";
            this.uxShowDate.Width = 125;
            this.uxShowDate.DataPropertyName = "ShowDate";
            // 
            // uxShowTime
            // 
            //this.uxShowTime.HeaderText = "Show Time";
            //this.uxShowTime.MinimumWidth = 6;
            //this.uxShowTime.Name = "uxShowTime";
            //this.uxShowTime.Width = 125;
            // 
            // uxTitleSearchLabel
            // 
            this.uxTitleSearchLabel.AutoSize = true;
            this.uxTitleSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleSearchLabel.Location = new System.Drawing.Point(48, 100);
            this.uxTitleSearchLabel.Name = "uxTitleSearchLabel";
            this.uxTitleSearchLabel.Size = new System.Drawing.Size(95, 20);
            this.uxTitleSearchLabel.TabIndex = 10;
            this.uxTitleSearchLabel.Text = "Movie Title:";
            // 
            // uxShowDateTimePicker
            // 
            this.uxShowDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxShowDateTimePicker.Location = new System.Drawing.Point(170, 206);
            this.uxShowDateTimePicker.Name = "uxShowDateTimePicker";
            this.uxShowDateTimePicker.Size = new System.Drawing.Size(299, 26);
            this.uxShowDateTimePicker.TabIndex = 11;
            // 
            // uxShowDateLabel
            // 
            this.uxShowDateLabel.AutoSize = true;
            this.uxShowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowDateLabel.Location = new System.Drawing.Point(25, 210);
            this.uxShowDateLabel.Name = "uxShowDateLabel";
            this.uxShowDateLabel.Size = new System.Drawing.Size(118, 20);
            this.uxShowDateLabel.TabIndex = 12;
            this.uxShowDateLabel.Text = "Showing Date:";
            // 
            // uxShowTimeLabel
            // 
            this.uxShowTimeLabel.AutoSize = true;
            this.uxShowTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowTimeLabel.Location = new System.Drawing.Point(24, 246);
            this.uxShowTimeLabel.Name = "uxShowTimeLabel";
            this.uxShowTimeLabel.Size = new System.Drawing.Size(119, 20);
            this.uxShowTimeLabel.TabIndex = 13;
            this.uxShowTimeLabel.Text = "Showing Time:";
            // 
            // uxShowTimesBox
            // 
            this.uxShowTimesBox.FormattingEnabled = true;
            this.uxShowTimesBox.Items.AddRange(new object[] {
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM",
            "10:00 PM",
            "11:00 PM",
            "12:00 AM"});
            this.uxShowTimesBox.Location = new System.Drawing.Point(170, 244);
            this.uxShowTimesBox.Name = "uxShowTimesBox";
            this.uxShowTimesBox.Size = new System.Drawing.Size(121, 24);
            this.uxShowTimesBox.TabIndex = 14;
            // 
            // uxSearchOptionsBox
            // 
            this.uxSearchOptionsBox.FormattingEnabled = true;
            this.uxSearchOptionsBox.Items.AddRange(new object[] {
            "Exclude Date",
            "Include Date"});
            this.uxSearchOptionsBox.Location = new System.Drawing.Point(573, 14);
            this.uxSearchOptionsBox.Name = "uxSearchOptionsBox";
            this.uxSearchOptionsBox.Size = new System.Drawing.Size(121, 24);
            this.uxSearchOptionsBox.TabIndex = 15;
            // 
            // uxSearchOptionsLabel
            // 
            this.uxSearchOptionsLabel.AutoSize = true;
            this.uxSearchOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchOptionsLabel.Location = new System.Drawing.Point(475, 16);
            this.uxSearchOptionsLabel.Name = "uxSearchOptionsLabel";
            this.uxSearchOptionsLabel.Size = new System.Drawing.Size(92, 20);
            this.uxSearchOptionsLabel.TabIndex = 16;
            this.uxSearchOptionsLabel.Text = "Search By:";
            // 
            // uxCustomerNameLabel
            // 
            this.uxCustomerNameLabel.AutoSize = true;
            this.uxCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerNameLabel.Location = new System.Drawing.Point(12, 136);
            this.uxCustomerNameLabel.Name = "uxCustomerNameLabel";
            this.uxCustomerNameLabel.Size = new System.Drawing.Size(136, 20);
            this.uxCustomerNameLabel.TabIndex = 17;
            this.uxCustomerNameLabel.Text = "Customer Name:";
            // 
            // uxCustomerNameBox
            // 
            this.uxCustomerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerNameBox.Location = new System.Drawing.Point(170, 133);
            this.uxCustomerNameBox.Name = "uxCustomerNameBox";
            this.uxCustomerNameBox.Size = new System.Drawing.Size(299, 26);
            this.uxCustomerNameBox.TabIndex = 18;
            // 
            // uxCustomerTypeLabel
            // 
            this.uxCustomerTypeLabel.AutoSize = true;
            this.uxCustomerTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerTypeLabel.Location = new System.Drawing.Point(12, 173);
            this.uxCustomerTypeLabel.Name = "uxCustomerTypeLabel";
            this.uxCustomerTypeLabel.Size = new System.Drawing.Size(128, 20);
            this.uxCustomerTypeLabel.TabIndex = 20;
            this.uxCustomerTypeLabel.Text = "Customer Type:";
            // 
            // uxCustomerTypeBox
            // 
            this.uxCustomerTypeBox.FormattingEnabled = true;
            this.uxCustomerTypeBox.Items.AddRange(new object[] {
            "Child",
            "Student",
            "Adult",
            "Senior",
            "Military"});
            this.uxCustomerTypeBox.Location = new System.Drawing.Point(170, 169);
            this.uxCustomerTypeBox.Name = "uxCustomerTypeBox";
            this.uxCustomerTypeBox.Size = new System.Drawing.Size(121, 24);
            this.uxCustomerTypeBox.TabIndex = 21;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(16, 503);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(109, 34);
            this.uxSearchButton.TabIndex = 22;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxExecuteButton
            // 
            this.uxExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExecuteButton.Location = new System.Drawing.Point(592, 503);
            this.uxExecuteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxExecuteButton.Name = "uxExecuteButton";
            this.uxExecuteButton.Size = new System.Drawing.Size(109, 34);
            this.uxExecuteButton.TabIndex = 23;
            this.uxExecuteButton.Text = "Execute";
            this.uxExecuteButton.UseVisualStyleBackColor = true;
            this.uxExecuteButton.Click += new System.EventHandler(this.uxExecuteButton_Click);
            // 
            // EditShowingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 548);
            this.Controls.Add(this.uxExecuteButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxCustomerTypeBox);
            this.Controls.Add(this.uxCustomerTypeLabel);
            this.Controls.Add(this.uxCustomerNameBox);
            this.Controls.Add(this.uxCustomerNameLabel);
            this.Controls.Add(this.uxSearchOptionsLabel);
            this.Controls.Add(this.uxSearchOptionsBox);
            this.Controls.Add(this.uxShowTimesBox);
            this.Controls.Add(this.uxShowTimeLabel);
            this.Controls.Add(this.uxShowDateLabel);
            this.Controls.Add(this.uxShowDateTimePicker);
            this.Controls.Add(this.uxTitleSearchLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxTitleSearchBox);
            this.Controls.Add(this.uxEditOptionsLabel);
            this.Controls.Add(this.uxEditTypesBox);
            this.Name = "EditShowingsForm";
            this.Text = "EditShowingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox uxEditTypesBox;
        private System.Windows.Forms.Label uxEditOptionsLabel;
        private System.Windows.Forms.TextBox uxTitleSearchBox;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label uxTitleSearchLabel;
        private System.Windows.Forms.DateTimePicker uxShowDateTimePicker;
        private System.Windows.Forms.Label uxShowDateLabel;
        private System.Windows.Forms.Label uxShowTimeLabel;
        private System.Windows.Forms.ComboBox uxShowTimesBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxCustomerAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxMovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxShowDate;
        //private System.Windows.Forms.DataGridViewTextBoxColumn uxShowTime;
        private System.Windows.Forms.ComboBox uxSearchOptionsBox;
        private System.Windows.Forms.Label uxSearchOptionsLabel;
        private System.Windows.Forms.Label uxCustomerNameLabel;
        private System.Windows.Forms.TextBox uxCustomerNameBox;
        private System.Windows.Forms.Label uxCustomerTypeLabel;
        private System.Windows.Forms.ComboBox uxCustomerTypeBox;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxExecuteButton;
    }
}