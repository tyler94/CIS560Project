namespace MovieTheaterApplication
{
    partial class ModifyMovieForm
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
            this.uxMovieSearchLabel = new System.Windows.Forms.Label();
            this.uxMovieSearchBox = new System.Windows.Forms.TextBox();
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.uxMovieEntriesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxLengthBox = new System.Windows.Forms.TextBox();
            this.uxLengthLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxRatingBox = new System.Windows.Forms.TextBox();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxEndDateLabel = new System.Windows.Forms.Label();
            this.uxGenreBox = new System.Windows.Forms.TextBox();
            this.uxEndDateBox = new System.Windows.Forms.TextBox();
            this.uxReleaseDateBox = new System.Windows.Forms.TextBox();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxStudioLabel = new System.Windows.Forms.Label();
            this.uxStudioBox = new System.Windows.Forms.TextBox();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxDirectorBox = new System.Windows.Forms.TextBox();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxMovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxStudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxFilmRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxFilmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMovieSearchLabel
            // 
            this.uxMovieSearchLabel.AutoSize = true;
            this.uxMovieSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxMovieSearchLabel.Location = new System.Drawing.Point(12, 18);
            this.uxMovieSearchLabel.Name = "uxMovieSearchLabel";
            this.uxMovieSearchLabel.Size = new System.Drawing.Size(168, 20);
            this.uxMovieSearchLabel.TabIndex = 5;
            this.uxMovieSearchLabel.Text = "Enter the Movie Title:";
            // 
            // uxMovieSearchBox
            // 
            this.uxMovieSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxMovieSearchBox.Location = new System.Drawing.Point(12, 50);
            this.uxMovieSearchBox.Name = "uxMovieSearchBox";
            this.uxMovieSearchBox.Size = new System.Drawing.Size(313, 26);
            this.uxMovieSearchBox.TabIndex = 4;
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxMovieTitle,
            this.uxDirector,
            this.uxReleaseDate,
            this.uxEndDate,
            this.uxStudio,
            this.uxGenre,
            this.uxFilmRating,
            this.uxFilmLength});
            this.uxMovieEntries.Location = new System.Drawing.Point(16, 130);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(685, 84);
            this.uxMovieEntries.TabIndex = 10;
            // 
            // uxMovieEntriesLabel
            // 
            this.uxMovieEntriesLabel.AutoSize = true;
            this.uxMovieEntriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxMovieEntriesLabel.Location = new System.Drawing.Point(12, 95);
            this.uxMovieEntriesLabel.Name = "uxMovieEntriesLabel";
            this.uxMovieEntriesLabel.Size = new System.Drawing.Size(207, 20);
            this.uxMovieEntriesLabel.TabIndex = 11;
            this.uxMovieEntriesLabel.Text = "Current Movie Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(274, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter New Information Below:";
            // 
            // uxLengthBox
            // 
            this.uxLengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxLengthBox.Location = new System.Drawing.Point(490, 475);
            this.uxLengthBox.Name = "uxLengthBox";
            this.uxLengthBox.Size = new System.Drawing.Size(207, 26);
            this.uxLengthBox.TabIndex = 33;
            // 
            // uxLengthLabel
            // 
            this.uxLengthLabel.AutoSize = true;
            this.uxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxLengthLabel.Location = new System.Drawing.Point(374, 478);
            this.uxLengthLabel.Name = "uxLengthLabel";
            this.uxLengthLabel.Size = new System.Drawing.Size(97, 20);
            this.uxLengthLabel.TabIndex = 32;
            this.uxLengthLabel.Text = "Film Length";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxRatingLabel.Location = new System.Drawing.Point(374, 436);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(94, 20);
            this.uxRatingLabel.TabIndex = 31;
            this.uxRatingLabel.Text = "Film Rating";
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxRatingBox.Location = new System.Drawing.Point(490, 433);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(207, 26);
            this.uxRatingBox.TabIndex = 30;
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxGenreLabel.Location = new System.Drawing.Point(413, 394);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(55, 20);
            this.uxGenreLabel.TabIndex = 29;
            this.uxGenreLabel.Text = "Genre";
            // 
            // uxEndDateLabel
            // 
            this.uxEndDateLabel.AutoSize = true;
            this.uxEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxEndDateLabel.Location = new System.Drawing.Point(41, 475);
            this.uxEndDateLabel.Name = "uxEndDateLabel";
            this.uxEndDateLabel.Size = new System.Drawing.Size(79, 20);
            this.uxEndDateLabel.TabIndex = 28;
            this.uxEndDateLabel.Text = "End Date";
            // 
            // uxGenreBox
            // 
            this.uxGenreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxGenreBox.Location = new System.Drawing.Point(490, 391);
            this.uxGenreBox.Name = "uxGenreBox";
            this.uxGenreBox.Size = new System.Drawing.Size(207, 26);
            this.uxGenreBox.TabIndex = 27;
            // 
            // uxEndDateBox
            // 
            this.uxEndDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxEndDateBox.Location = new System.Drawing.Point(142, 472);
            this.uxEndDateBox.Name = "uxEndDateBox";
            this.uxEndDateBox.Size = new System.Drawing.Size(207, 26);
            this.uxEndDateBox.TabIndex = 26;
            // 
            // uxReleaseDateBox
            // 
            this.uxReleaseDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxReleaseDateBox.Location = new System.Drawing.Point(142, 433);
            this.uxReleaseDateBox.Name = "uxReleaseDateBox";
            this.uxReleaseDateBox.Size = new System.Drawing.Size(207, 26);
            this.uxReleaseDateBox.TabIndex = 25;
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(9, 436);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(111, 20);
            this.uxReleaseDateLabel.TabIndex = 24;
            this.uxReleaseDateLabel.Text = "Release Date";
            // 
            // uxStudioLabel
            // 
            this.uxStudioLabel.AutoSize = true;
            this.uxStudioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxStudioLabel.Location = new System.Drawing.Point(412, 353);
            this.uxStudioLabel.Name = "uxStudioLabel";
            this.uxStudioLabel.Size = new System.Drawing.Size(56, 20);
            this.uxStudioLabel.TabIndex = 23;
            this.uxStudioLabel.Text = "Studio";
            // 
            // uxStudioBox
            // 
            this.uxStudioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxStudioBox.Location = new System.Drawing.Point(490, 350);
            this.uxStudioBox.Name = "uxStudioBox";
            this.uxStudioBox.Size = new System.Drawing.Size(207, 26);
            this.uxStudioBox.TabIndex = 22;
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxDirectorLabel.Location = new System.Drawing.Point(50, 397);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(70, 20);
            this.uxDirectorLabel.TabIndex = 21;
            this.uxDirectorLabel.Text = "Director";
            // 
            // uxDirectorBox
            // 
            this.uxDirectorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxDirectorBox.Location = new System.Drawing.Point(142, 393);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(207, 26);
            this.uxDirectorBox.TabIndex = 20;
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTitleLabel.Location = new System.Drawing.Point(79, 356);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(41, 20);
            this.uxTitleLabel.TabIndex = 19;
            this.uxTitleLabel.Text = "Title";
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTitleBox.Location = new System.Drawing.Point(142, 353);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(207, 26);
            this.uxTitleBox.TabIndex = 18;
            // 
            // uxMovieTitle
            // 
            this.uxMovieTitle.HeaderText = "Movie Title";
            this.uxMovieTitle.MinimumWidth = 6;
            this.uxMovieTitle.Name = "uxMovieTitle";
            this.uxMovieTitle.Width = 125;
            // 
            // uxDirector
            // 
            this.uxDirector.HeaderText = "Director";
            this.uxDirector.MinimumWidth = 6;
            this.uxDirector.Name = "uxDirector";
            this.uxDirector.Width = 125;
            // 
            // uxReleaseDate
            // 
            this.uxReleaseDate.HeaderText = "Release Date";
            this.uxReleaseDate.MinimumWidth = 6;
            this.uxReleaseDate.Name = "uxReleaseDate";
            this.uxReleaseDate.Width = 125;
            // 
            // uxEndDate
            // 
            this.uxEndDate.HeaderText = "End Date";
            this.uxEndDate.MinimumWidth = 6;
            this.uxEndDate.Name = "uxEndDate";
            this.uxEndDate.Width = 125;
            // 
            // uxStudio
            // 
            this.uxStudio.HeaderText = "Studio";
            this.uxStudio.MinimumWidth = 6;
            this.uxStudio.Name = "uxStudio";
            this.uxStudio.Width = 125;
            // 
            // uxGenre
            // 
            this.uxGenre.HeaderText = "Genre";
            this.uxGenre.MinimumWidth = 6;
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Width = 125;
            // 
            // uxFilmRating
            // 
            this.uxFilmRating.HeaderText = "Film Rating";
            this.uxFilmRating.MinimumWidth = 6;
            this.uxFilmRating.Name = "uxFilmRating";
            this.uxFilmRating.Width = 125;
            // 
            // uxFilmLength
            // 
            this.uxFilmLength.HeaderText = "Film Length";
            this.uxFilmLength.MinimumWidth = 6;
            this.uxFilmLength.Name = "uxFilmLength";
            this.uxFilmLength.Width = 125;
            // 
            // ModifyMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 523);
            this.Controls.Add(this.uxLengthBox);
            this.Controls.Add(this.uxLengthLabel);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxEndDateLabel);
            this.Controls.Add(this.uxGenreBox);
            this.Controls.Add(this.uxEndDateBox);
            this.Controls.Add(this.uxReleaseDateBox);
            this.Controls.Add(this.uxReleaseDateLabel);
            this.Controls.Add(this.uxStudioLabel);
            this.Controls.Add(this.uxStudioBox);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxTitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMovieEntriesLabel);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxMovieSearchLabel);
            this.Controls.Add(this.uxMovieSearchBox);
            this.Name = "ModifyMovieForm";
            this.Text = "ModifyMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMovieSearchLabel;
        private System.Windows.Forms.TextBox uxMovieSearchBox;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label uxMovieEntriesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxMovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxStudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxFilmRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxFilmLength;
        private System.Windows.Forms.TextBox uxLengthBox;
        private System.Windows.Forms.Label uxLengthLabel;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.TextBox uxRatingBox;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.Label uxEndDateLabel;
        private System.Windows.Forms.TextBox uxGenreBox;
        private System.Windows.Forms.TextBox uxEndDateBox;
        private System.Windows.Forms.TextBox uxReleaseDateBox;
        private System.Windows.Forms.Label uxReleaseDateLabel;
        private System.Windows.Forms.Label uxStudioLabel;
        private System.Windows.Forms.TextBox uxStudioBox;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.TextBox uxDirectorBox;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.TextBox uxTitleBox;
    }
}