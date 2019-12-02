namespace MovieTheaterApplication
{
    partial class ActiveMoviesForm
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
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.uxActiveShowings = new System.Windows.Forms.RadioButton();
            this.uxInactiveShowings = new System.Windows.Forms.RadioButton();
            this.uxAllMovies = new System.Windows.Forms.RadioButton();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxSearchOptionsBox = new System.Windows.Forms.ComboBox();
            this.uxSearchOptionsLabel = new System.Windows.Forms.Label();
            this.uxSearchEntry = new System.Windows.Forms.TextBox();
            this.uxAddMovie = new System.Windows.Forms.Button();
            this.uxModifyMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.AllowUserToAddRows = false;
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxMovieEntries.Location = new System.Drawing.Point(12, 283);
            this.uxMovieEntries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(667, 416);
            this.uxMovieEntries.TabIndex = 0;
            // 
            // uxActiveShowings
            // 
            this.uxActiveShowings.AutoSize = true;
            this.uxActiveShowings.Checked = true;
            this.uxActiveShowings.Location = new System.Drawing.Point(12, 229);
            this.uxActiveShowings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxActiveShowings.Name = "uxActiveShowings";
            this.uxActiveShowings.Size = new System.Drawing.Size(199, 21);
            this.uxActiveShowings.TabIndex = 1;
            this.uxActiveShowings.TabStop = true;
            this.uxActiveShowings.Text = "only show available movies";
            this.uxActiveShowings.UseVisualStyleBackColor = true;
            this.uxActiveShowings.CheckedChanged += new System.EventHandler(this.uxActiveShowings_CheckedChanged);
            // 
            // uxInactiveShowings
            // 
            this.uxInactiveShowings.AutoSize = true;
            this.uxInactiveShowings.Location = new System.Drawing.Point(12, 256);
            this.uxInactiveShowings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxInactiveShowings.Name = "uxInactiveShowings";
            this.uxInactiveShowings.Size = new System.Drawing.Size(215, 21);
            this.uxInactiveShowings.TabIndex = 2;
            this.uxInactiveShowings.TabStop = true;
            this.uxInactiveShowings.Text = "only show unavailable movies";
            this.uxInactiveShowings.UseVisualStyleBackColor = true;
            this.uxInactiveShowings.CheckedChanged += new System.EventHandler(this.uxInactiveShowings_CheckedChanged);
            // 
            // uxAllMovies
            // 
            this.uxAllMovies.AutoSize = true;
            this.uxAllMovies.Location = new System.Drawing.Point(12, 202);
            this.uxAllMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxAllMovies.Name = "uxAllMovies";
            this.uxAllMovies.Size = new System.Drawing.Size(127, 21);
            this.uxAllMovies.TabIndex = 3;
            this.uxAllMovies.Text = "show all movies";
            this.uxAllMovies.UseVisualStyleBackColor = true;
            this.uxAllMovies.CheckedChanged += new System.EventHandler(this.uxAllMovies_CheckedChanged);
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(581, 242);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(109, 34);
            this.uxSearchButton.TabIndex = 4;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxSearchOptionsBox
            // 
            this.uxSearchOptionsBox.FormattingEnabled = true;
            this.uxSearchOptionsBox.Items.AddRange(new object[] {
            "None",
            "Movie Title",
            "Movie Director",
            "Movie Genre"});
            this.uxSearchOptionsBox.Location = new System.Drawing.Point(107, 7);
            this.uxSearchOptionsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSearchOptionsBox.Name = "uxSearchOptionsBox";
            this.uxSearchOptionsBox.Size = new System.Drawing.Size(121, 24);
            this.uxSearchOptionsBox.TabIndex = 5;
            // 
            // uxSearchOptionsLabel
            // 
            this.uxSearchOptionsLabel.AutoSize = true;
            this.uxSearchOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchOptionsLabel.Location = new System.Drawing.Point(8, 9);
            this.uxSearchOptionsLabel.Name = "uxSearchOptionsLabel";
            this.uxSearchOptionsLabel.Size = new System.Drawing.Size(92, 20);
            this.uxSearchOptionsLabel.TabIndex = 6;
            this.uxSearchOptionsLabel.Text = "Search By:";
            // 
            // uxSearchEntry
            // 
            this.uxSearchEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchEntry.Location = new System.Drawing.Point(396, 6);
            this.uxSearchEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxSearchEntry.Name = "uxSearchEntry";
            this.uxSearchEntry.Size = new System.Drawing.Size(295, 26);
            this.uxSearchEntry.TabIndex = 7;
            // 
            // uxAddMovie
            // 
            this.uxAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddMovie.Location = new System.Drawing.Point(261, 242);
            this.uxAddMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxAddMovie.Name = "uxAddMovie";
            this.uxAddMovie.Size = new System.Drawing.Size(127, 34);
            this.uxAddMovie.TabIndex = 9;
            this.uxAddMovie.Text = "Add Movie";
            this.uxAddMovie.UseVisualStyleBackColor = true;
            this.uxAddMovie.Click += new System.EventHandler(this.uxAddMovie_Click);
            // 
            // uxModifyMovieButton
            // 
            this.uxModifyMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxModifyMovieButton.Location = new System.Drawing.Point(407, 242);
            this.uxModifyMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxModifyMovieButton.Name = "uxModifyMovieButton";
            this.uxModifyMovieButton.Size = new System.Drawing.Size(155, 34);
            this.uxModifyMovieButton.TabIndex = 10;
            this.uxModifyMovieButton.Text = "Modify Movie";
            this.uxModifyMovieButton.UseVisualStyleBackColor = true;
            this.uxModifyMovieButton.Click += new System.EventHandler(this.uxModifyMovieButton_Click);
            // 
            // ActiveMoviesForm
            // 
            this.AcceptButton = this.uxSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 713);
            this.Controls.Add(this.uxModifyMovieButton);
            this.Controls.Add(this.uxAddMovie);
            this.Controls.Add(this.uxSearchEntry);
            this.Controls.Add(this.uxSearchOptionsLabel);
            this.Controls.Add(this.uxSearchOptionsBox);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxAllMovies);
            this.Controls.Add(this.uxInactiveShowings);
            this.Controls.Add(this.uxActiveShowings);
            this.Controls.Add(this.uxMovieEntries);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActiveMoviesForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.RadioButton uxActiveShowings;
        private System.Windows.Forms.RadioButton uxInactiveShowings;
        private System.Windows.Forms.RadioButton uxAllMovies;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ComboBox uxSearchOptionsBox;
        private System.Windows.Forms.Label uxSearchOptionsLabel;
        private System.Windows.Forms.TextBox uxSearchEntry;
        private System.Windows.Forms.Button uxAddMovie;
        private System.Windows.Forms.Button uxModifyMovieButton;
    }
}