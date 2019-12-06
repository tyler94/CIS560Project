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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxMovieSearchLabel = new System.Windows.Forms.Label();
            this.uxMovieSearchBox = new System.Windows.Forms.TextBox();
            this.uxMovieEntries = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uxLengthLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxReleaseDateBox = new System.Windows.Forms.TextBox();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxStudioLabel = new System.Windows.Forms.Label();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxTitleBox = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.uxDirectorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxStudioBox = new System.Windows.Forms.ComboBox();
            this.uxRatingBox = new System.Windows.Forms.ComboBox();
            this.uxLengthBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxLengthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uxMovieSearchLabel
            // 
            this.uxMovieSearchLabel.AutoSize = true;
            this.uxMovieSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxMovieSearchLabel.Location = new System.Drawing.Point(9, 15);
            this.uxMovieSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxMovieSearchLabel.Name = "uxMovieSearchLabel";
            this.uxMovieSearchLabel.Size = new System.Drawing.Size(142, 17);
            this.uxMovieSearchLabel.TabIndex = 5;
            this.uxMovieSearchLabel.Text = "Enter the Movie Title:";
            // 
            // uxMovieSearchBox
            // 
            this.uxMovieSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxMovieSearchBox.Location = new System.Drawing.Point(155, 12);
            this.uxMovieSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMovieSearchBox.Name = "uxMovieSearchBox";
            this.uxMovieSearchBox.Size = new System.Drawing.Size(242, 23);
            this.uxMovieSearchBox.TabIndex = 4;
            // 
            // uxMovieEntries
            // 
            this.uxMovieEntries.AllowUserToAddRows = false;
            this.uxMovieEntries.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uxMovieEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxMovieEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxMovieEntries.DefaultCellStyle = dataGridViewCellStyle2;
            this.uxMovieEntries.Location = new System.Drawing.Point(12, 40);
            this.uxMovieEntries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMovieEntries.Name = "uxMovieEntries";
            this.uxMovieEntries.RowHeadersWidth = 51;
            this.uxMovieEntries.RowTemplate.Height = 24;
            this.uxMovieEntries.Size = new System.Drawing.Size(514, 208);
            this.uxMovieEntries.TabIndex = 10;
            this.uxMovieEntries.SelectionChanged += new System.EventHandler(this.uxMovieEntries_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(169, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter New Information Below:";
            // 
            // uxLengthLabel
            // 
            this.uxLengthLabel.AutoSize = true;
            this.uxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxLengthLabel.Location = new System.Drawing.Point(280, 320);
            this.uxLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLengthLabel.Name = "uxLengthLabel";
            this.uxLengthLabel.Size = new System.Drawing.Size(81, 17);
            this.uxLengthLabel.TabIndex = 32;
            this.uxLengthLabel.Text = "Film Length";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxRatingLabel.Location = new System.Drawing.Point(280, 351);
            this.uxRatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(78, 17);
            this.uxRatingLabel.TabIndex = 31;
            this.uxRatingLabel.Text = "Film Rating";
            // 
            // uxReleaseDateBox
            // 
            this.uxReleaseDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDateBox.Location = new System.Drawing.Point(106, 349);
            this.uxReleaseDateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxReleaseDateBox.Name = "uxReleaseDateBox";
            this.uxReleaseDateBox.Size = new System.Drawing.Size(156, 20);
            this.uxReleaseDateBox.TabIndex = 25;
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(7, 351);
            this.uxReleaseDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(94, 17);
            this.uxReleaseDateLabel.TabIndex = 24;
            this.uxReleaseDateLabel.Text = "Release Date";
            // 
            // uxStudioLabel
            // 
            this.uxStudioLabel.AutoSize = true;
            this.uxStudioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxStudioLabel.Location = new System.Drawing.Point(310, 288);
            this.uxStudioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxStudioLabel.Name = "uxStudioLabel";
            this.uxStudioLabel.Size = new System.Drawing.Size(48, 17);
            this.uxStudioLabel.TabIndex = 23;
            this.uxStudioLabel.Text = "Studio";
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxDirectorLabel.Location = new System.Drawing.Point(38, 320);
            this.uxDirectorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(58, 17);
            this.uxDirectorLabel.TabIndex = 21;
            this.uxDirectorLabel.Text = "Director";
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uxTitleLabel.Location = new System.Drawing.Point(59, 289);
            this.uxTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.uxTitleLabel.TabIndex = 19;
            this.uxTitleLabel.Text = "Title";
            // 
            // uxTitleBox
            // 
            this.uxTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTitleBox.Location = new System.Drawing.Point(106, 287);
            this.uxTitleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxTitleBox.Name = "uxTitleBox";
            this.uxTitleBox.Size = new System.Drawing.Size(156, 20);
            this.uxTitleBox.TabIndex = 18;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(444, 8);
            this.uxSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(82, 28);
            this.uxSearchButton.TabIndex = 34;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxSubmit
            // 
            this.uxSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmit.Location = new System.Drawing.Point(239, 397);
            this.uxSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(82, 28);
            this.uxSubmit.TabIndex = 37;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.uxSubmit_Click);
            // 
            // uxDirectorBox
            // 
            this.uxDirectorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorBox.FormattingEnabled = true;
            this.uxDirectorBox.Location = new System.Drawing.Point(106, 319);
            this.uxDirectorBox.Name = "uxDirectorBox";
            this.uxDirectorBox.Size = new System.Drawing.Size(156, 21);
            this.uxDirectorBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date: month-day-year";
            // 
            // uxStudioBox
            // 
            this.uxStudioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStudioBox.FormattingEnabled = true;
            this.uxStudioBox.Location = new System.Drawing.Point(368, 286);
            this.uxStudioBox.Name = "uxStudioBox";
            this.uxStudioBox.Size = new System.Drawing.Size(156, 21);
            this.uxStudioBox.TabIndex = 53;
            // 
            // uxRatingBox
            // 
            this.uxRatingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.uxRatingBox.Location = new System.Drawing.Point(368, 351);
            this.uxRatingBox.Name = "uxRatingBox";
            this.uxRatingBox.Size = new System.Drawing.Size(156, 21);
            this.uxRatingBox.TabIndex = 54;
            // 
            // uxLengthBox
            // 
            this.uxLengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLengthBox.Location = new System.Drawing.Point(368, 320);
            this.uxLengthBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.uxLengthBox.Name = "uxLengthBox";
            this.uxLengthBox.Size = new System.Drawing.Size(156, 20);
            this.uxLengthBox.TabIndex = 55;
            this.uxLengthBox.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // ModifyMovieForm
            // 
            this.AcceptButton = this.uxSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 434);
            this.Controls.Add(this.uxLengthBox);
            this.Controls.Add(this.uxRatingBox);
            this.Controls.Add(this.uxStudioBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxDirectorBox);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxLengthLabel);
            this.Controls.Add(this.uxRatingLabel);
            this.Controls.Add(this.uxReleaseDateBox);
            this.Controls.Add(this.uxReleaseDateLabel);
            this.Controls.Add(this.uxStudioLabel);
            this.Controls.Add(this.uxDirectorLabel);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxTitleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMovieEntries);
            this.Controls.Add(this.uxMovieSearchLabel);
            this.Controls.Add(this.uxMovieSearchBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyMovieForm";
            this.Text = "ModifyMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxMovieEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxLengthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMovieSearchLabel;
        private System.Windows.Forms.TextBox uxMovieSearchBox;
        private System.Windows.Forms.DataGridView uxMovieEntries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxLengthLabel;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.TextBox uxReleaseDateBox;
        private System.Windows.Forms.Label uxReleaseDateLabel;
        private System.Windows.Forms.Label uxStudioLabel;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.TextBox uxTitleBox;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.Button uxSubmit;
        private System.Windows.Forms.ComboBox uxDirectorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxStudioBox;
        private System.Windows.Forms.ComboBox uxRatingBox;
        private System.Windows.Forms.NumericUpDown uxLengthBox;
    }
}