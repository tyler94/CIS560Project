namespace MovieTheaterApplication
{
    partial class StatisticsForm
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
            this.uxSerachOptionsLabel = new System.Windows.Forms.Label();
            this.uxStatisticTypes = new System.Windows.Forms.ComboBox();
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.uxDateEntryLabel = new System.Windows.Forms.Label();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxMonthLabel = new System.Windows.Forms.Label();
            this.uxDayLabel = new System.Windows.Forms.Label();
            this.uxRun = new System.Windows.Forms.Button();
            this.uxYearEntryBox = new System.Windows.Forms.NumericUpDown();
            this.uxMonthEntryBox = new System.Windows.Forms.NumericUpDown();
            this.uxDayEntryBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYearEntryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthEntryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDayEntryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSerachOptionsLabel
            // 
            this.uxSerachOptionsLabel.AutoSize = true;
            this.uxSerachOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSerachOptionsLabel.Location = new System.Drawing.Point(5, 10);
            this.uxSerachOptionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxSerachOptionsLabel.Name = "uxSerachOptionsLabel";
            this.uxSerachOptionsLabel.Size = new System.Drawing.Size(77, 17);
            this.uxSerachOptionsLabel.TabIndex = 9;
            this.uxSerachOptionsLabel.Text = "Search By:";
            // 
            // uxStatisticTypes
            // 
            this.uxStatisticTypes.FormattingEnabled = true;
            this.uxStatisticTypes.Items.AddRange(new object[] {
            "Highest Grossing Film(s)",
            "Highest Number of Viewings",
            "Most popular age group (by film)",
            "Most popular age group (overall)",
            "Highest Customer count by Year",
            "Highest Customer count by Month",
            "Highest Customer count by Day"});
            this.uxStatisticTypes.Location = new System.Drawing.Point(86, 9);
            this.uxStatisticTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxStatisticTypes.Name = "uxStatisticTypes";
            this.uxStatisticTypes.Size = new System.Drawing.Size(272, 21);
            this.uxStatisticTypes.TabIndex = 8;
            this.uxStatisticTypes.SelectedIndexChanged += new System.EventHandler(this.uxStatisticTypes_SelectedIndexChanged);
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.AllowUserToAddRows = false;
            this.uxMovieEntries.AllowUserToDeleteRows = false;
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Location = new System.Drawing.Point(7, 144);
            this.uxMovieEntries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(442, 253);
            this.uxMovieEntries.TabIndex = 10;
            // 
            // uxDateEntryLabel
            // 
            this.uxDateEntryLabel.AutoSize = true;
            this.uxDateEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateEntryLabel.Location = new System.Drawing.Point(5, 41);
            this.uxDateEntryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxDateEntryLabel.Name = "uxDateEntryLabel";
            this.uxDateEntryLabel.Size = new System.Drawing.Size(118, 17);
            this.uxDateEntryLabel.TabIndex = 12;
            this.uxDateEntryLabel.Text = "Enter date below:";
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYearLabel.Location = new System.Drawing.Point(11, 67);
            this.uxYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(42, 17);
            this.uxYearLabel.TabIndex = 16;
            this.uxYearLabel.Text = "Year:";
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMonthLabel.Location = new System.Drawing.Point(2, 93);
            this.uxMonthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(51, 17);
            this.uxMonthLabel.TabIndex = 17;
            this.uxMonthLabel.Text = "Month:";
            // 
            // uxDayLabel
            // 
            this.uxDayLabel.AutoSize = true;
            this.uxDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDayLabel.Location = new System.Drawing.Point(16, 119);
            this.uxDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxDayLabel.Name = "uxDayLabel";
            this.uxDayLabel.Size = new System.Drawing.Size(37, 17);
            this.uxDayLabel.TabIndex = 18;
            this.uxDayLabel.Text = "Day:";
            // 
            // uxRun
            // 
            this.uxRun.Location = new System.Drawing.Point(374, 7);
            this.uxRun.Name = "uxRun";
            this.uxRun.Size = new System.Drawing.Size(75, 23);
            this.uxRun.TabIndex = 19;
            this.uxRun.Text = "Run";
            this.uxRun.UseVisualStyleBackColor = true;
            this.uxRun.Click += new System.EventHandler(this.uxRun_Click);
            // 
            // uxYearEntryBox
            // 
            this.uxYearEntryBox.Location = new System.Drawing.Point(58, 67);
            this.uxYearEntryBox.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.uxYearEntryBox.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.uxYearEntryBox.Name = "uxYearEntryBox";
            this.uxYearEntryBox.Size = new System.Drawing.Size(102, 20);
            this.uxYearEntryBox.TabIndex = 20;
            this.uxYearEntryBox.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // uxMonthEntryBox
            // 
            this.uxMonthEntryBox.Location = new System.Drawing.Point(58, 93);
            this.uxMonthEntryBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.uxMonthEntryBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxMonthEntryBox.Name = "uxMonthEntryBox";
            this.uxMonthEntryBox.Size = new System.Drawing.Size(102, 20);
            this.uxMonthEntryBox.TabIndex = 21;
            this.uxMonthEntryBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxDayEntryBox
            // 
            this.uxDayEntryBox.Location = new System.Drawing.Point(58, 119);
            this.uxDayEntryBox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.uxDayEntryBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxDayEntryBox.Name = "uxDayEntryBox";
            this.uxDayEntryBox.Size = new System.Drawing.Size(102, 20);
            this.uxDayEntryBox.TabIndex = 22;
            this.uxDayEntryBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 408);
            this.Controls.Add(this.uxDayEntryBox);
            this.Controls.Add(this.uxMonthEntryBox);
            this.Controls.Add(this.uxYearEntryBox);
            this.Controls.Add(this.uxRun);
            this.Controls.Add(this.uxDayLabel);
            this.Controls.Add(this.uxMonthLabel);
            this.Controls.Add(this.uxYearLabel);
            this.Controls.Add(this.uxDateEntryLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxSerachOptionsLabel);
            this.Controls.Add(this.uxStatisticTypes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYearEntryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthEntryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDayEntryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxSerachOptionsLabel;
        private System.Windows.Forms.ComboBox uxStatisticTypes;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label uxDateEntryLabel;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.Label uxDayLabel;
        private System.Windows.Forms.Button uxRun;
        private System.Windows.Forms.NumericUpDown uxYearEntryBox;
        private System.Windows.Forms.NumericUpDown uxMonthEntryBox;
        private System.Windows.Forms.NumericUpDown uxDayEntryBox;
    }
}