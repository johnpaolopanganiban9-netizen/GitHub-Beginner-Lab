namespace StudentProfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGitHubBeginnerLab = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // lblGitHubBeginnerLab
            // 
            lblGitHubBeginnerLab.AutoSize = true;
            lblGitHubBeginnerLab.Location = new Point(11, 9);
            lblGitHubBeginnerLab.Margin = new Padding(2, 0, 2, 0);
            lblGitHubBeginnerLab.Name = "lblGitHubBeginnerLab";
            lblGitHubBeginnerLab.Size = new Size(117, 15);
            lblGitHubBeginnerLab.TabIndex = 0;
            lblGitHubBeginnerLab.Text = "GitHub Beginner Lab";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 1;
            label1.Text = "Contact Number: 093450945";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(399, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(149, 23);
            txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Search: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(61, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(lblGitHubBeginnerLab);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGitHubBeginnerLab;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
    }
}
