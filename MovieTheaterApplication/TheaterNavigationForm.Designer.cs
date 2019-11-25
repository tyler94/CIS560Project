namespace MovieTheaterApplication
{
    partial class TheaterNavigationForm
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
            this.uxActiveMovies = new System.Windows.Forms.Button();
            this.uxEditShowings = new System.Windows.Forms.Button();
            this.uxStatistics = new System.Windows.Forms.Button();
            this.uxLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxActiveMovies
            // 
            this.uxActiveMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActiveMovies.Location = new System.Drawing.Point(37, 24);
            this.uxActiveMovies.Name = "uxActiveMovies";
            this.uxActiveMovies.Size = new System.Drawing.Size(150, 70);
            this.uxActiveMovies.TabIndex = 0;
            this.uxActiveMovies.Text = "Active Movies";
            this.uxActiveMovies.UseVisualStyleBackColor = true;
            this.uxActiveMovies.Click += new System.EventHandler(this.uxActiveMovies_Click);
            // 
            // uxEditShowings
            // 
            this.uxEditShowings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEditShowings.Location = new System.Drawing.Point(37, 122);
            this.uxEditShowings.Name = "uxEditShowings";
            this.uxEditShowings.Size = new System.Drawing.Size(150, 70);
            this.uxEditShowings.TabIndex = 1;
            this.uxEditShowings.Text = "Edit Showings";
            this.uxEditShowings.UseVisualStyleBackColor = true;
            this.uxEditShowings.Click += new System.EventHandler(this.uxEditShowings_Click);
            // 
            // uxStatistics
            // 
            this.uxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatistics.Location = new System.Drawing.Point(37, 225);
            this.uxStatistics.Name = "uxStatistics";
            this.uxStatistics.Size = new System.Drawing.Size(150, 70);
            this.uxStatistics.TabIndex = 2;
            this.uxStatistics.Text = "Statistics";
            this.uxStatistics.UseVisualStyleBackColor = true;
            this.uxStatistics.Click += new System.EventHandler(this.uxStatistics_Click);
            // 
            // uxLogout
            // 
            this.uxLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogout.Location = new System.Drawing.Point(37, 326);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(150, 70);
            this.uxLogout.TabIndex = 3;
            this.uxLogout.Text = "Logout";
            this.uxLogout.UseVisualStyleBackColor = true;
            this.uxLogout.Click += new System.EventHandler(this.uxLogout_Click);
            // 
            // TheaterNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 426);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.uxStatistics);
            this.Controls.Add(this.uxEditShowings);
            this.Controls.Add(this.uxActiveMovies);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TheaterNavigationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxActiveMovies;
        private System.Windows.Forms.Button uxEditShowings;
        private System.Windows.Forms.Button uxStatistics;
        private System.Windows.Forms.Button uxLogout;
    }
}

