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
            this.uxStatisticOptions.Location = new System.Drawing.Point(12, 130);
            this.uxStatisticOptions.Name = "uxStatisticOptions";
            this.uxStatisticOptions.Size = new System.Drawing.Size(766, 157);
            this.uxStatisticOptions.TabIndex = 0;
            // 
            // uxSearchOptionsLabel
            // 
            this.uxSerachOptionsLabel.AutoSize = true;
            this.uxSerachOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSerachOptionsLabel.Location = new System.Drawing.Point(7, 12);
            this.uxSerachOptionsLabel.Name = "uxSearchOptionsLabel";
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
            this.uxStatisticTypes.Location = new System.Drawing.Point(105, 12);
            this.uxStatisticTypes.Name = "uxStatisticTypes";
            this.uxStatisticTypes.Size = new System.Drawing.Size(121, 24);
            this.uxStatisticTypes.TabIndex = 8;
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Location = new System.Drawing.Point(12, 293);
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
            this.uxStatisticOptionsLabel.Location = new System.Drawing.Point(15, 107);
            this.uxStatisticOptionsLabel.Name = "uxStatisticOptionsLabel";
            this.uxStatisticOptionsLabel.Size = new System.Drawing.Size(133, 20);
            this.uxStatisticOptionsLabel.TabIndex = 11;
            this.uxStatisticOptionsLabel.Text = "Display Options:";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 546);
            this.Controls.Add(this.uxStatisticOptionsLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxSerachOptionsLabel);
            this.Controls.Add(this.uxStatisticTypes);
            this.Controls.Add(this.uxStatisticOptions);
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