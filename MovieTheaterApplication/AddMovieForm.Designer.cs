namespace MovieTheaterApplication
{
    partial class AddMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxEndDateLabel = new System.Windows.Forms.Label();
            this.uxEndDateBox = new System.Windows.Forms.TextBox();
            this.uxReleaseDateBox = new System.Windows.Forms.TextBox();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxLengthLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.uxGenreBox = new System.Windows.Forms.TextBox();
            this.uxStudioLabel = new System.Windows.Forms.Label();
            this.uxApplyButton = new System.Windows.Forms.Button();
            this.uxActorOneBox = new System.Windows.Forms.TextBox();
            this.uxActorsLabel = new System.Windows.Forms.Label();
            this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.uxLengthBox = new System.Windows.Forms.NumericUpDown();
            this.uxDirectorBox = new System.Windows.Forms.ComboBox();
            this.uxStudioBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxLengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Movie Information Below";
            // 
            // uxEndDateLabel
            // 
            this.uxEndDateLabel.AutoSize = true;
            this.uxEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxEndDateLabel.Location = new System.Drawing.Point(32, 135);
            this.uxEndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxEndDateLabel.Name = "uxEndDateLabel";
            this.uxEndDateLabel.Size = new System.Drawing.Size(67, 17);
            this.uxEndDateLabel.TabIndex = 36;
            this.uxEndDateLabel.Text = "End Date";
            // 
            // uxEndDateBox
            // 
            this.uxEndDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxEndDateBox.Location = new System.Drawing.Point(105, 132);
            this.uxEndDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxEndDateBox.Name = "uxEndDateBox";
            this.uxEndDateBox.Size = new System.Drawing.Size(156, 23);
            this.uxEndDateBox.TabIndex = 35;
            this.uxToolTip.SetToolTip(this.uxEndDateBox, "month-day-year");
            this.uxEndDateBox.MouseHover += new System.EventHandler(this.uxEndDateBox_MouseHover);
            // 
            // uxReleaseDateBox
            // 
            this.uxReleaseDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxReleaseDateBox.Location = new System.Drawing.Point(105, 101);
            this.uxReleaseDateBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxReleaseDateBox.Name = "uxReleaseDateBox";
            this.uxReleaseDateBox.Size = new System.Drawing.Size(156, 23);
            this.uxReleaseDateBox.TabIndex = 34;
            this.uxToolTip.SetToolTip(this.uxReleaseDateBox, "month-day-year");
            this.uxReleaseDateBox.MouseHover += new System.EventHandler(this.uxReleaseDateBox_MouseHover);
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(-1, 104);
            this.uxReleaseDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(99, 17);
            this.uxReleaseDateLabel.TabIndex = 33;
            this.uxReleaseDateLabel.Text = "Release Date*";
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxDirectorLabel.Location = new System.Drawing.Point(36, 72);
            this.uxDirectorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(63, 17);
            this.uxDirectorLabel.TabIndex = 32;
            this.uxDirectorLabel.Text = "Director*";
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTitleLabel.Location = new System.Drawing.Point(58, 38);
            this.uxTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(40, 17);
            this.uxTitleLabel.TabIndex = 30;
            this.uxTitleLabel.Text = "Title*";
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTitleBox.Location = new System.Drawing.Point(105, 36);
            this.uxTitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(156, 23);
            this.uxTitleBox.TabIndex = 29;
            // 
            // uxLengthLabel
            // 
            this.uxLengthLabel.AutoSize = true;
            this.uxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxLengthLabel.Location = new System.Drawing.Point(18, 271);
            this.uxLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLengthLabel.Name = "uxLengthLabel";
            this.uxLengthLabel.Size = new System.Drawing.Size(86, 17);
            this.uxLengthLabel.TabIndex = 43;
            this.uxLengthLabel.Text = "Film Length*";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxRatingLabel.Location = new System.Drawing.Point(18, 236);
            this.uxRatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(83, 17);
            this.uxRatingLabel.TabIndex = 42;
            this.uxRatingLabel.Text = "Film Rating*";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxGenreLabel.Location = new System.Drawing.Point(41, 203);
            this.uxGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(55, 17);
            this.uxGenreLabel.TabIndex = 40;
            this.uxGenreLabel.Text = "Genres";
            // 
            // uxGenreBox
            // 
            this.uxGenreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxGenreBox.Location = new System.Drawing.Point(105, 200);
            this.uxGenreBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxGenreBox.Name = "uxGenreBox";
            this.uxGenreBox.Size = new System.Drawing.Size(156, 23);
            this.uxGenreBox.TabIndex = 39;
            // 
            // uxStudioLabel
            // 
            this.uxStudioLabel.AutoSize = true;
            this.uxStudioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxStudioLabel.Location = new System.Drawing.Point(46, 169);
            this.uxStudioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxStudioLabel.Name = "uxStudioLabel";
            this.uxStudioLabel.Size = new System.Drawing.Size(53, 17);
            this.uxStudioLabel.TabIndex = 38;
            this.uxStudioLabel.Text = "Studio*";
            // 
            // uxApplyButton
            // 
            this.uxApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxApplyButton.Location = new System.Drawing.Point(179, 339);
            this.uxApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxApplyButton.Name = "uxApplyButton";
            this.uxApplyButton.Size = new System.Drawing.Size(82, 28);
            this.uxApplyButton.TabIndex = 45;
            this.uxApplyButton.Text = "Apply";
            this.uxApplyButton.UseVisualStyleBackColor = true;
            this.uxApplyButton.Click += new System.EventHandler(this.uxApplyButton_Click);
            // 
            // uxActorOneBox
            // 
            this.uxActorOneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxActorOneBox.Location = new System.Drawing.Point(105, 301);
            this.uxActorOneBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxActorOneBox.Name = "uxActorOneBox";
            this.uxActorOneBox.Size = new System.Drawing.Size(156, 23);
            this.uxActorOneBox.TabIndex = 46;
            // 
            // uxActorsLabel
            // 
            this.uxActorsLabel.AutoSize = true;
            this.uxActorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxActorsLabel.Location = new System.Drawing.Point(43, 304);
            this.uxActorsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxActorsLabel.Name = "uxActorsLabel";
            this.uxActorsLabel.Size = new System.Drawing.Size(58, 17);
            this.uxActorsLabel.TabIndex = 50;
            this.uxActorsLabel.Text = "Actor(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Date: month-day-year\r\nGenres/Actors: one, two, three\r\n";
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.FormattingEnabled = true;
            this.uxRatingBox.Items.AddRange(new object[] {
            "G",
            "TV-G",
            "M",
            "GP",
            "PG",
            "TV-PG",
            "PG-13",
            "TV-14",
            "R",
            "X",
            "NC-17",
            "Not Rated"});
            this.uxRatingBox.Location = new System.Drawing.Point(105, 235);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(156, 21);
            this.uxRatingBox.TabIndex = 52;
            // 
            // uxLengthBox
            // 
            this.uxLengthBox.Location = new System.Drawing.Point(105, 271);
            this.uxLengthBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.uxLengthBox.Name = "uxLengthBox";
            this.uxLengthBox.Size = new System.Drawing.Size(156, 20);
            this.uxLengthBox.TabIndex = 53;
            this.uxLengthBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // uxDirectorBox
            // 
            this.uxDirectorBox.FormattingEnabled = true;
            this.uxDirectorBox.Location = new System.Drawing.Point(105, 71);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(156, 21);
            this.uxDirectorBox.TabIndex = 54;
            // 
            // uxStudioBox
            // 
            this.uxStudioBox.FormattingEnabled = true;
            this.uxStudioBox.Location = new System.Drawing.Point(105, 168);
            this.uxStudioBox.Name = "uxStudioBox";
            this.uxStudioBox.Size = new System.Drawing.Size(156, 21);
            this.uxStudioBox.TabIndex = 55;
            // 
            // AddMovieForm
            // 
            this.AcceptButton = this.uxApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.Controls.Add(this.uxStudioBox);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxLengthBox);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxActorsLabel);
            this.Controls.Add(this.uxActorOneBox);
            this.Controls.Add(this.uxApplyButton);
            this.Controls.Add(this.uxLengthLabel);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxGenreBox);
            this.Controls.Add(this.uxStudioLabel);
            this.Controls.Add(this.uxEndDateLabel);
            this.Controls.Add(this.uxEndDateBox);
            this.Controls.Add(this.uxReleaseDateBox);
            this.Controls.Add(this.uxReleaseDateLabel);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxTitleBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddMovieForm";
            this.Text = "AddMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxLengthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxEndDateLabel;
        private System.Windows.Forms.TextBox uxEndDateBox;
        private System.Windows.Forms.TextBox uxReleaseDateBox;
        private System.Windows.Forms.Label uxReleaseDateLabel;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.Label uxLengthLabel;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.Label uxGenreLabel;
        private System.Windows.Forms.TextBox uxGenreBox;
        private System.Windows.Forms.Label uxStudioLabel;
        private System.Windows.Forms.Button uxApplyButton;
        private System.Windows.Forms.TextBox uxActorOneBox;
        private System.Windows.Forms.Label uxActorsLabel;
        private System.Windows.Forms.ToolTip uxToolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.NumericUpDown uxLengthBox;
        private System.Windows.Forms.ComboBox uxDirectorBox;
        private System.Windows.Forms.ComboBox uxStudioBox;
    }
}