namespace MovieTheaterApplication
{
    partial class LoginForm
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
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxPasswordLabel = new System.Windows.Forms.Label();
            this.uxUsernameBox = new System.Windows.Forms.TextBox();
            this.uxPasswordBox = new System.Windows.Forms.TextBox();
            this.uxConnectButton = new System.Windows.Forms.Button();
            this.uxInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameLabel.Location = new System.Drawing.Point(13, 97);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.uxUsernameLabel.TabIndex = 0;
            this.uxUsernameLabel.Text = "Username:";
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPasswordLabel.Location = new System.Drawing.Point(13, 134);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.uxPasswordLabel.TabIndex = 1;
            this.uxPasswordLabel.Text = "Password:";
            // 
            // uxUsernameBox
            // 
            this.uxUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameBox.Location = new System.Drawing.Point(106, 94);
            this.uxUsernameBox.Name = "uxUsernameBox";
            this.uxUsernameBox.Size = new System.Drawing.Size(219, 26);
            this.uxUsernameBox.TabIndex = 2;
            this.uxUsernameBox.TextChanged += new System.EventHandler(this.uxUsernameBox_TextChanged);
            // 
            // uxPasswordBox
            // 
            this.uxPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPasswordBox.Location = new System.Drawing.Point(106, 131);
            this.uxPasswordBox.Name = "uxPasswordBox";
            this.uxPasswordBox.PasswordChar = '•';
            this.uxPasswordBox.Size = new System.Drawing.Size(219, 26);
            this.uxPasswordBox.TabIndex = 3;
            this.uxPasswordBox.TextChanged += new System.EventHandler(this.uxPasswordBox_TextChanged);
            // 
            // uxConnectButton
            // 
            this.uxConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConnectButton.Location = new System.Drawing.Point(239, 185);
            this.uxConnectButton.Name = "uxConnectButton";
            this.uxConnectButton.Size = new System.Drawing.Size(103, 29);
            this.uxConnectButton.TabIndex = 4;
            this.uxConnectButton.Text = "Connect";
            this.uxConnectButton.UseVisualStyleBackColor = true;
            this.uxConnectButton.Click += new System.EventHandler(this.uxConnectButton_Click);
            // 
            // uxInfoLabel
            // 
            this.uxInfoLabel.AutoSize = true;
            this.uxInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInfoLabel.Location = new System.Drawing.Point(40, 29);
            this.uxInfoLabel.Name = "uxInfoLabel";
            this.uxInfoLabel.Size = new System.Drawing.Size(210, 20);
            this.uxInfoLabel.TabIndex = 5;
            this.uxInfoLabel.Text = "Please login to the database";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.uxConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 243);
            this.Controls.Add(this.uxInfoLabel);
            this.Controls.Add(this.uxConnectButton);
            this.Controls.Add(this.uxPasswordBox);
            this.Controls.Add(this.uxUsernameBox);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUsernameLabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.Label uxPasswordLabel;
        private System.Windows.Forms.TextBox uxUsernameBox;
        private System.Windows.Forms.TextBox uxPasswordBox;
        private System.Windows.Forms.Button uxConnectButton;
        private System.Windows.Forms.Label uxInfoLabel;
    }
}