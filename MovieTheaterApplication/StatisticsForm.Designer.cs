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
            this.uxStatisticOptionsLabel = new System.Windows.Forms.Label();
            this.uxDateEntryLabel = new System.Windows.Forms.Label();
            this.uxDayLabel = new System.Windows.Forms.Label();
            this.uxDayEntryBox = new System.Windows.Forms.TextBox();
            this.uxMonthEntryBox = new System.Windows.Forms.TextBox();
            this.uxMonthLabel = new System.Windows.Forms.Label();
            this.uxYearEntryBox = new System.Windows.Forms.TextBox();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxStatisticOptions = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSerachOptionsLabel
            // 
            this.uxSerachOptionsLabel.AutoSize = true;
            this.uxSerachOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSerachOptionsLabel.Location = new System.Drawing.Point(7, 12);
            this.uxSerachOptionsLabel.Name = "uxSerachOptionsLabel";
            this.uxSerachOptionsLabel.Size = new System.Drawing.Size(92, 20);
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
            this.uxStatisticTypes.Location = new System.Drawing.Point(115, 11);
            this.uxStatisticTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxStatisticTypes.Name = "uxStatisticTypes";
            this.uxStatisticTypes.Size = new System.Drawing.Size(361, 24);
            this.uxStatisticTypes.TabIndex = 8;
            this.uxStatisticTypes.SelectedIndexChanged += new System.EventHandler(this.uxStatisticTypes_SelectedIndexChanged);
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Location = new System.Drawing.Point(12, 293);
            this.uxMovieEntries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(953, 241);
            this.uxMovieEntries.TabIndex = 10;
            // 
            // uxStatisticOptionsLabel
            // 
            this.uxStatisticOptionsLabel.AutoSize = true;
            this.uxStatisticOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatisticOptionsLabel.Location = new System.Drawing.Point(275, 132);
            this.uxStatisticOptionsLabel.Name = "uxStatisticOptionsLabel";
            this.uxStatisticOptionsLabel.Size = new System.Drawing.Size(133, 20);
            this.uxStatisticOptionsLabel.TabIndex = 11;
            this.uxStatisticOptionsLabel.Text = "Display Options:";
            // 
            // uxDateEntryLabel
            // 
            this.uxDateEntryLabel.AutoSize = true;
            this.uxDateEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateEntryLabel.Location = new System.Drawing.Point(12, 132);
            this.uxDateEntryLabel.Name = "uxDateEntryLabel";
            this.uxDateEntryLabel.Size = new System.Drawing.Size(109, 20);
            this.uxDateEntryLabel.TabIndex = 24;
            this.uxDateEntryLabel.Text = "Enter a Date:";
            this.uxDateEntryLabel.Visible = false;
            // 
            // uxDayLabel
            // 
            this.uxDayLabel.AutoSize = true;
            this.uxDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDayLabel.Location = new System.Drawing.Point(58, 239);
            this.uxDayLabel.Name = "uxDayLabel";
            this.uxDayLabel.Size = new System.Drawing.Size(39, 20);
            this.uxDayLabel.TabIndex = 23;
            this.uxDayLabel.Text = "Day";
            this.uxDayLabel.Visible = false;
            // 
            // uxDayEntryBox
            // 
            this.uxDayEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDayEntryBox.Location = new System.Drawing.Point(115, 236);
            this.uxDayEntryBox.Name = "uxDayEntryBox";
            this.uxDayEntryBox.Size = new System.Drawing.Size(109, 26);
            this.uxDayEntryBox.TabIndex = 22;
            this.uxDayEntryBox.Visible = false;
            // 
            // uxMonthEntryBox
            // 
            this.uxMonthEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMonthEntryBox.Location = new System.Drawing.Point(115, 204);
            this.uxMonthEntryBox.Name = "uxMonthEntryBox";
            this.uxMonthEntryBox.Size = new System.Drawing.Size(109, 26);
            this.uxMonthEntryBox.TabIndex = 21;
            this.uxMonthEntryBox.Visible = false;
            // 
            // uxMonthLabel
            // 
            this.uxMonthLabel.AutoSize = true;
            this.uxMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMonthLabel.Location = new System.Drawing.Point(42, 207);
            this.uxMonthLabel.Name = "uxMonthLabel";
            this.uxMonthLabel.Size = new System.Drawing.Size(55, 20);
            this.uxMonthLabel.TabIndex = 20;
            this.uxMonthLabel.Text = "Month";
            this.uxMonthLabel.Visible = false;
            // 
            // uxYearEntryBox
            // 
            this.uxYearEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYearEntryBox.Location = new System.Drawing.Point(115, 172);
            this.uxYearEntryBox.Name = "uxYearEntryBox";
            this.uxYearEntryBox.Size = new System.Drawing.Size(109, 26);
            this.uxYearEntryBox.TabIndex = 19;
            this.uxYearEntryBox.Visible = false;
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxYearLabel.Location = new System.Drawing.Point(54, 175);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(43, 20);
            this.uxYearLabel.TabIndex = 18;
            this.uxYearLabel.Text = "Year";
            this.uxYearLabel.Visible = false;
            // 
            // uxStatisticOptions
            // 
            this.uxStatisticOptions.FormattingEnabled = true;
            this.uxStatisticOptions.Location = new System.Drawing.Point(279, 155);
            this.uxStatisticOptions.Name = "uxStatisticOptions";
            this.uxStatisticOptions.Size = new System.Drawing.Size(677, 123);
            this.uxStatisticOptions.TabIndex = 25;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 546);
            this.Controls.Add(this.uxStatisticOptions);
            this.Controls.Add(this.uxDateEntryLabel);
            this.Controls.Add(this.uxDayLabel);
            this.Controls.Add(this.uxDayEntryBox);
            this.Controls.Add(this.uxMonthEntryBox);
            this.Controls.Add(this.uxMonthLabel);
            this.Controls.Add(this.uxYearEntryBox);
            this.Controls.Add(this.uxYearLabel);
            this.Controls.Add(this.uxStatisticOptionsLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxSerachOptionsLabel);
            this.Controls.Add(this.uxStatisticTypes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxSerachOptionsLabel;
        private System.Windows.Forms.ComboBox uxStatisticTypes;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label uxStatisticOptionsLabel;
        private System.Windows.Forms.Label uxDateEntryLabel;
        private System.Windows.Forms.Label uxDayLabel;
        private System.Windows.Forms.TextBox uxDayEntryBox;
        private System.Windows.Forms.TextBox uxMonthEntryBox;
        private System.Windows.Forms.Label uxMonthLabel;
        private System.Windows.Forms.TextBox uxYearEntryBox;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.CheckedListBox uxStatisticOptions;
    }
}