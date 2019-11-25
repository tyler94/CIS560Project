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
            this.uxSerachOptionsLabel = new System.Windows.Forms.Label();
            this.uxTitleSearchBox = new System.Windows.Forms.TextBox();
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.uxTitleSearchLabel = new System.Windows.Forms.Label();
            this.uxShowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxShowDateLabel = new System.Windows.Forms.Label();
            this.uxShowTimeLabel = new System.Windows.Forms.Label();
            this.uxShowTimesBox = new System.Windows.Forms.ComboBox();
            this.uxTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxShowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // uxSerachOptionsLabel
            // 
            this.uxSerachOptionsLabel.AutoSize = true;
            this.uxSerachOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSerachOptionsLabel.Location = new System.Drawing.Point(12, 14);
            this.uxSerachOptionsLabel.Name = "uxSerachOptionsLabel";
            this.uxSerachOptionsLabel.Size = new System.Drawing.Size(84, 20);
            this.uxSerachOptionsLabel.TabIndex = 7;
            this.uxSerachOptionsLabel.Text = "Edit Type:";
            // 
            // uxTitleSearchBox
            // 
            this.uxTitleSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleSearchBox.Location = new System.Drawing.Point(139, 155);
            this.uxTitleSearchBox.Name = "uxTitleSearchBox";
            this.uxTitleSearchBox.Size = new System.Drawing.Size(299, 26);
            this.uxTitleSearchBox.TabIndex = 8;
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxTitle,
            this.uxShowDate,
            this.uxShowTime});
            this.uxMovieEntries.Location = new System.Drawing.Point(16, 290);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(576, 204);
            this.uxMovieEntries.TabIndex = 9;
            // 
            // uxTitleSearchLabel
            // 
            this.uxTitleSearchLabel.AutoSize = true;
            this.uxTitleSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleSearchLabel.Location = new System.Drawing.Point(38, 158);
            this.uxTitleSearchLabel.Name = "uxTitleSearchLabel";
            this.uxTitleSearchLabel.Size = new System.Drawing.Size(95, 20);
            this.uxTitleSearchLabel.TabIndex = 10;
            this.uxTitleSearchLabel.Text = "Movie Title:";
            // 
            // uxShowDateTimePicker
            // 
            this.uxShowDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxShowDateTimePicker.Location = new System.Drawing.Point(139, 199);
            this.uxShowDateTimePicker.Name = "uxShowDateTimePicker";
            this.uxShowDateTimePicker.Size = new System.Drawing.Size(299, 26);
            this.uxShowDateTimePicker.TabIndex = 11;
            // 
            // uxShowDateLabel
            // 
            this.uxShowDateLabel.AutoSize = true;
            this.uxShowDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowDateLabel.Location = new System.Drawing.Point(12, 202);
            this.uxShowDateLabel.Name = "uxShowDateLabel";
            this.uxShowDateLabel.Size = new System.Drawing.Size(118, 20);
            this.uxShowDateLabel.TabIndex = 12;
            this.uxShowDateLabel.Text = "Showing Date:";
            // 
            // uxShowTimeLabel
            // 
            this.uxShowTimeLabel.AutoSize = true;
            this.uxShowTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShowTimeLabel.Location = new System.Drawing.Point(12, 250);
            this.uxShowTimeLabel.Name = "uxShowTimeLabel";
            this.uxShowTimeLabel.Size = new System.Drawing.Size(119, 20);
            this.uxShowTimeLabel.TabIndex = 13;
            this.uxShowTimeLabel.Text = "Showing Time:";
            // 
            // uxShowTimesBox
            // 
            this.uxShowTimesBox.FormattingEnabled = true;
            this.uxShowTimesBox.Items.AddRange(new object[] {
            "Add Viewing",
            "Modify Viewing",
            "Delete Viewing"});
            this.uxShowTimesBox.Location = new System.Drawing.Point(139, 250);
            this.uxShowTimesBox.Name = "uxShowTimesBox";
            this.uxShowTimesBox.Size = new System.Drawing.Size(121, 24);
            this.uxShowTimesBox.TabIndex = 14;
            // 
            // uxTitle
            // 
            this.uxTitle.HeaderText = "Title";
            this.uxTitle.MinimumWidth = 6;
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Width = 125;
            // 
            // uxShowDate
            // 
            this.uxShowDate.HeaderText = "Show Date";
            this.uxShowDate.MinimumWidth = 6;
            this.uxShowDate.Name = "uxShowDate";
            this.uxShowDate.Width = 125;
            // 
            // uxShowTime
            // 
            this.uxShowTime.HeaderText = "Show Time";
            this.uxShowTime.MinimumWidth = 6;
            this.uxShowTime.Name = "uxShowTime";
            this.uxShowTime.Width = 125;
            // 
            // EditShowingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 547);
            this.Controls.Add(this.uxShowTimesBox);
            this.Controls.Add(this.uxShowTimeLabel);
            this.Controls.Add(this.uxShowDateLabel);
            this.Controls.Add(this.uxShowDateTimePicker);
            this.Controls.Add(this.uxTitleSearchLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxTitleSearchBox);
            this.Controls.Add(this.uxSerachOptionsLabel);
            this.Controls.Add(this.uxEditTypesBox);
            this.Name = "EditShowingsForm";
            this.Text = "EditShowingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox uxEditTypesBox;
        private System.Windows.Forms.Label uxSerachOptionsLabel;
        private System.Windows.Forms.TextBox uxTitleSearchBox;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label uxTitleSearchLabel;
        private System.Windows.Forms.DateTimePicker uxShowDateTimePicker;
        private System.Windows.Forms.Label uxShowDateLabel;
        private System.Windows.Forms.Label uxShowTimeLabel;
        private System.Windows.Forms.ComboBox uxShowTimesBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxShowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxShowTime;
    }
}