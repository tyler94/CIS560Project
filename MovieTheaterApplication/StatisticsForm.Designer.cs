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
            this.uxStatisticOptions = new System.Windows.Forms.CheckedListBox();
            this.uxSerachOptionsLabel = new System.Windows.Forms.Label();
            this.uxStatisticTypes = new System.Windows.Forms.ComboBox();
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.uxStatisticOptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // uxStatisticOptions
            // 
            this.uxStatisticOptions.FormattingEnabled = true;
            this.uxStatisticOptions.Location = new System.Drawing.Point(9, 106);
            this.uxStatisticOptions.Margin = new System.Windows.Forms.Padding(2);
            this.uxStatisticOptions.Name = "uxStatisticOptions";
            this.uxStatisticOptions.Size = new System.Drawing.Size(576, 124);
            this.uxStatisticOptions.TabIndex = 0;
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
            this.uxStatisticTypes.Margin = new System.Windows.Forms.Padding(2);
            this.uxStatisticTypes.Name = "uxStatisticTypes";
            this.uxStatisticTypes.Size = new System.Drawing.Size(272, 21);
            this.uxStatisticTypes.TabIndex = 8;
            this.uxStatisticTypes.SelectedIndexChanged += new System.EventHandler(this.uxStatisticTypes_SelectedIndexChanged);
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Location = new System.Drawing.Point(9, 238);
            this.uxMovieEntries.Margin = new System.Windows.Forms.Padding(2);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(715, 196);
            this.uxMovieEntries.TabIndex = 10;
            // 
            // uxStatisticOptionsLabel
            // 
            this.uxStatisticOptionsLabel.AutoSize = true;
            this.uxStatisticOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatisticOptionsLabel.Location = new System.Drawing.Point(11, 87);
            this.uxStatisticOptionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxStatisticOptionsLabel.Name = "uxStatisticOptionsLabel";
            this.uxStatisticOptionsLabel.Size = new System.Drawing.Size(111, 17);
            this.uxStatisticOptionsLabel.TabIndex = 11;
            this.uxStatisticOptionsLabel.Text = "Display Options:";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 444);
            this.Controls.Add(this.uxStatisticOptionsLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxSerachOptionsLabel);
            this.Controls.Add(this.uxStatisticTypes);
            this.Controls.Add(this.uxStatisticOptions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox uxStatisticOptions;
        private System.Windows.Forms.Label uxSerachOptionsLabel;
        private System.Windows.Forms.ComboBox uxStatisticTypes;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label uxStatisticOptionsLabel;
    }
}