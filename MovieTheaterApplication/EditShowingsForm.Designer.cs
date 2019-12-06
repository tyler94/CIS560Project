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
            this.uxTitleSearchLabel = new System.Windows.Forms.Label();
            this.uxShowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxShowDateLabel = new System.Windows.Forms.Label();
            this.uxShowTimeLabel = new System.Windows.Forms.Label();
            this.uxShowTimesBox = new System.Windows.Forms.ComboBox();
            this.uxCustomerNameLabel = new System.Windows.Forms.Label();
            this.uxCustomerNameBox = new System.Windows.Forms.TextBox();
            this.uxCustomerTypeLabel = new System.Windows.Forms.Label();
            this.uxCustomerTypeBox = new System.Windows.Forms.ComboBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxExecuteButton = new System.Windows.Forms.Button();
            this.uxIncludeMovieTitle = new System.Windows.Forms.CheckBox();
            this.uxIncludeCustomerName = new System.Windows.Forms.CheckBox();
            this.uxIncludeCustomerType = new System.Windows.Forms.CheckBox();
            this.uxIncludeShowingDateAndTime = new System.Windows.Forms.CheckBox();
            this.uxSearchBy = new System.Windows.Forms.Label();
            this.uxGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            this.uxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxEditTypesBox
            // 
            this.uxEditTypesBox.FormattingEnabled = true;
            this.uxEditTypesBox.Items.AddRange(new object[] {
            "Add Viewing",
            "Modify Viewing",
            "Search Only"});
            this.uxEditTypesBox.Location = new System.Drawing.Point(432, 10);
            this.uxEditTypesBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxEditTypesBox.Name = "uxEditTypesBox";
            this.uxEditTypesBox.Size = new System.Drawing.Size(92, 21);
            this.uxEditTypesBox.TabIndex = 0;
            this.uxEditTypesBox.SelectedIndexChanged += new System.EventHandler(this.uxEditTypesBox_SelectedIndexChanged);
            // 
            // uxEditOptionsLabel
            // 
            this.uxEditOptionsLabel.AutoSize = true;
            this.uxEditOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEditOptionsLabel.Location = new System.Drawing.Point(359, 11);
            this.uxEditOptionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxEditOptionsLabel.Name = "uxEditOptionsLabel";
            this.uxEditOptionsLabel.Size = new System.Drawing.Size(72, 17);
            this.uxEditOptionsLabel.TabIndex = 7;
            this.uxEditOptionsLabel.Text = "Edit Type:";
            // 
            // uxTitleSearchBox
            // 
            this.uxTitleSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleSearchBox.Location = new System.Drawing.Point(157, 33);
            this.uxTitleSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxTitleSearchBox.Name = "uxTitleSearchBox";
            this.uxTitleSearchBox.Size = new System.Drawing.Size(225, 23);
            this.uxTitleSearchBox.TabIndex = 2;
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.AllowUserToAddRows = false;
            this.uxMovieEntries.AllowUserToDeleteRows = false;
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxCustomerName,
            this.uxCustomerAge,
            this.uxMovieTitle,
            this.uxShowDate});
            this.uxMovieEntries.Location = new System.Drawing.Point(12, 215);
            this.uxMovieEntries.Margin = new System.Windows.Forms.Padding(2);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(514, 167);
            this.uxMovieEntries.TabIndex = 10;
            this.uxMovieEntries.SelectionChanged += new System.EventHandler(this.uxMovieEntries_SelectionChanged);
            // 
            // uxCustomerName
            // 
            this.uxCustomerName.DataPropertyName = "CustomerName";
            this.uxCustomerName.HeaderText = "Customer Name";
            this.uxCustomerName.MinimumWidth = 6;
            this.uxCustomerName.Name = "uxCustomerName";
            this.uxCustomerName.Width = 125;
            // 
            // uxCustomerAge
            // 
            this.uxCustomerAge.DataPropertyName = "CustomerCategory";
            this.uxCustomerAge.HeaderText = "Customer Type";
            this.uxCustomerAge.MinimumWidth = 6;
            this.uxCustomerAge.Name = "uxCustomerAge";
            this.uxCustomerAge.Width = 125;
            // 
            // uxMovieTitle
            // 
            this.uxMovieTitle.DataPropertyName = "MovieTitle";
            this.uxMovieTitle.HeaderText = "Movie Title";
            this.uxMovieTitle.MinimumWidth = 6;
            this.uxMovieTitle.Name = "uxMovieTitle";
            this.uxMovieTitle.Width = 125;
            // 
            // uxShowDate
            // 
            this.uxShowDate.DataPropertyName = "ShowDate";
            this.uxShowDate.HeaderText = "Show Date";
            this.uxShowDate.MinimumWidth = 6;
            this.uxShowDate.Name = "uxShowDate";
            this.uxShowDate.Width = 125;
            // 
            // uxTitleSearchLabel
            // 
            this.uxTitleSearchLabel.AutoSize = true;
            this.uxTitleSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleSearchLabel.Location = new System.Drawing.Point(40, 36);
            this.uxTitleSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTitleSearchLabel.Name = "uxTitleSearchLabel";
            this.uxTitleSearchLabel.Size = new System.Drawing.Size(80, 17);
            this.uxTitleSearchLabel.TabIndex = 10;
            this.uxTitleSearchLabel.Text = "Movie Title:";
            // 
            // uxShowDateTimePicker
            // 
            this.uxShowDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxShowDateTimePicker.Location = new System.Drawing.Point(122, 10);
            this.uxShowDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.uxShowDateTimePicker.Name = "uxShowDateTimePicker";
            this.uxShowDateTimePicker.Size = new System.Drawing.Size(225, 23);
            this.uxShowDateTimePicker.TabIndex = 8;
            this.uxShowDateTimePicker.Value = new System.DateTime(2019, 12, 6, 0, 0, 0, 0);
            // 
            // uxShowDateLabel
            // 
            this.uxShowDateLabel.AutoSize = true;
            this.uxShowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowDateLabel.Location = new System.Drawing.Point(6, 15);
            this.uxShowDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxShowDateLabel.Name = "uxShowDateLabel";
            this.uxShowDateLabel.Size = new System.Drawing.Size(99, 17);
            this.uxShowDateLabel.TabIndex = 12;
            this.uxShowDateLabel.Text = "Showing Date:";
            // 
            // uxShowTimeLabel
            // 
            this.uxShowTimeLabel.AutoSize = true;
            this.uxShowTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowTimeLabel.Location = new System.Drawing.Point(6, 42);
            this.uxShowTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxShowTimeLabel.Name = "uxShowTimeLabel";
            this.uxShowTimeLabel.Size = new System.Drawing.Size(100, 17);
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
            this.uxShowTimesBox.Location = new System.Drawing.Point(122, 41);
            this.uxShowTimesBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxShowTimesBox.Name = "uxShowTimesBox";
            this.uxShowTimesBox.Size = new System.Drawing.Size(92, 21);
            this.uxShowTimesBox.TabIndex = 9;
            // 
            // uxCustomerNameLabel
            // 
            this.uxCustomerNameLabel.AutoSize = true;
            this.uxCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerNameLabel.Location = new System.Drawing.Point(40, 66);
            this.uxCustomerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCustomerNameLabel.Name = "uxCustomerNameLabel";
            this.uxCustomerNameLabel.Size = new System.Drawing.Size(113, 17);
            this.uxCustomerNameLabel.TabIndex = 17;
            this.uxCustomerNameLabel.Text = "Customer Name:";
            // 
            // uxCustomerNameBox
            // 
            this.uxCustomerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerNameBox.Location = new System.Drawing.Point(157, 63);
            this.uxCustomerNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxCustomerNameBox.Name = "uxCustomerNameBox";
            this.uxCustomerNameBox.Size = new System.Drawing.Size(225, 23);
            this.uxCustomerNameBox.TabIndex = 4;
            // 
            // uxCustomerTypeLabel
            // 
            this.uxCustomerTypeLabel.AutoSize = true;
            this.uxCustomerTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCustomerTypeLabel.Location = new System.Drawing.Point(40, 96);
            this.uxCustomerTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCustomerTypeLabel.Name = "uxCustomerTypeLabel";
            this.uxCustomerTypeLabel.Size = new System.Drawing.Size(108, 17);
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
            this.uxCustomerTypeBox.Location = new System.Drawing.Point(157, 95);
            this.uxCustomerTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxCustomerTypeBox.Name = "uxCustomerTypeBox";
            this.uxCustomerTypeBox.Size = new System.Drawing.Size(92, 21);
            this.uxCustomerTypeBox.TabIndex = 6;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(12, 388);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(82, 28);
            this.uxSearchButton.TabIndex = 11;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxExecuteButton
            // 
            this.uxExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExecuteButton.Location = new System.Drawing.Point(444, 388);
            this.uxExecuteButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxExecuteButton.Name = "uxExecuteButton";
            this.uxExecuteButton.Size = new System.Drawing.Size(82, 28);
            this.uxExecuteButton.TabIndex = 12;
            this.uxExecuteButton.Text = "Execute";
            this.uxExecuteButton.UseVisualStyleBackColor = true;
            this.uxExecuteButton.Click += new System.EventHandler(this.uxExecuteButton_Click);
            // 
            // uxIncludeMovieTitle
            // 
            this.uxIncludeMovieTitle.AutoSize = true;
            this.uxIncludeMovieTitle.Checked = true;
            this.uxIncludeMovieTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxIncludeMovieTitle.Location = new System.Drawing.Point(14, 38);
            this.uxIncludeMovieTitle.Name = "uxIncludeMovieTitle";
            this.uxIncludeMovieTitle.Size = new System.Drawing.Size(15, 14);
            this.uxIncludeMovieTitle.TabIndex = 1;
            this.uxIncludeMovieTitle.UseVisualStyleBackColor = true;
            this.uxIncludeMovieTitle.CheckedChanged += new System.EventHandler(this.uxIncludeMovieTitle_CheckedChanged);
            // 
            // uxIncludeCustomerName
            // 
            this.uxIncludeCustomerName.AutoSize = true;
            this.uxIncludeCustomerName.Location = new System.Drawing.Point(14, 68);
            this.uxIncludeCustomerName.Name = "uxIncludeCustomerName";
            this.uxIncludeCustomerName.Size = new System.Drawing.Size(15, 14);
            this.uxIncludeCustomerName.TabIndex = 3;
            this.uxIncludeCustomerName.UseVisualStyleBackColor = true;
            this.uxIncludeCustomerName.CheckedChanged += new System.EventHandler(this.uxIncludeCustomerName_CheckedChanged);
            // 
            // uxIncludeCustomerType
            // 
            this.uxIncludeCustomerType.AutoSize = true;
            this.uxIncludeCustomerType.Location = new System.Drawing.Point(14, 98);
            this.uxIncludeCustomerType.Name = "uxIncludeCustomerType";
            this.uxIncludeCustomerType.Size = new System.Drawing.Size(15, 14);
            this.uxIncludeCustomerType.TabIndex = 5;
            this.uxIncludeCustomerType.UseVisualStyleBackColor = true;
            this.uxIncludeCustomerType.CheckedChanged += new System.EventHandler(this.uxIncludeCustomerType_CheckedChanged);
            // 
            // uxIncludeShowingDateAndTime
            // 
            this.uxIncludeShowingDateAndTime.AutoSize = true;
            this.uxIncludeShowingDateAndTime.Location = new System.Drawing.Point(14, 153);
            this.uxIncludeShowingDateAndTime.Name = "uxIncludeShowingDateAndTime";
            this.uxIncludeShowingDateAndTime.Size = new System.Drawing.Size(15, 14);
            this.uxIncludeShowingDateAndTime.TabIndex = 7;
            this.uxIncludeShowingDateAndTime.UseVisualStyleBackColor = true;
            this.uxIncludeShowingDateAndTime.CheckedChanged += new System.EventHandler(this.uxIncludeShowingDateAndTime_CheckedChanged);
            // 
            // uxSearchBy
            // 
            this.uxSearchBy.AutoSize = true;
            this.uxSearchBy.Location = new System.Drawing.Point(1, 6);
            this.uxSearchBy.Name = "uxSearchBy";
            this.uxSearchBy.Size = new System.Drawing.Size(41, 26);
            this.uxSearchBy.TabIndex = 29;
            this.uxSearchBy.Text = "Search\r\nBy:\r\n";
            this.uxSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxGroupBox
            // 
            this.uxGroupBox.Controls.Add(this.uxShowDateTimePicker);
            this.uxGroupBox.Controls.Add(this.uxShowTimesBox);
            this.uxGroupBox.Controls.Add(this.uxShowTimeLabel);
            this.uxGroupBox.Controls.Add(this.uxShowDateLabel);
            this.uxGroupBox.Location = new System.Drawing.Point(35, 121);
            this.uxGroupBox.Name = "uxGroupBox";
            this.uxGroupBox.Size = new System.Drawing.Size(472, 70);
            this.uxGroupBox.TabIndex = 30;
            this.uxGroupBox.TabStop = false;
            // 
            // EditShowingsForm
            // 
            this.AcceptButton = this.uxSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 431);
            this.Controls.Add(this.uxGroupBox);
            this.Controls.Add(this.uxSearchBy);
            this.Controls.Add(this.uxIncludeShowingDateAndTime);
            this.Controls.Add(this.uxIncludeCustomerType);
            this.Controls.Add(this.uxIncludeCustomerName);
            this.Controls.Add(this.uxIncludeMovieTitle);
            this.Controls.Add(this.uxExecuteButton);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxCustomerTypeBox);
            this.Controls.Add(this.uxCustomerTypeLabel);
            this.Controls.Add(this.uxCustomerNameBox);
            this.Controls.Add(this.uxCustomerNameLabel);
            this.Controls.Add(this.uxTitleSearchLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxTitleSearchBox);
            this.Controls.Add(this.uxEditOptionsLabel);
            this.Controls.Add(this.uxEditTypesBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditShowingsForm";
            this.Text = "EditShowingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.uxGroupBox.ResumeLayout(false);
            this.uxGroupBox.PerformLayout();
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
        private System.Windows.Forms.Label uxCustomerNameLabel;
        private System.Windows.Forms.TextBox uxCustomerNameBox;
        private System.Windows.Forms.Label uxCustomerTypeLabel;
        private System.Windows.Forms.ComboBox uxCustomerTypeBox;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxExecuteButton;
        private System.Windows.Forms.CheckBox uxIncludeMovieTitle;
        private System.Windows.Forms.CheckBox uxIncludeCustomerName;
        private System.Windows.Forms.CheckBox uxIncludeCustomerType;
        private System.Windows.Forms.CheckBox uxIncludeShowingDateAndTime;
        private System.Windows.Forms.Label uxSearchBy;
        private System.Windows.Forms.GroupBox uxGroupBox;
    }
}