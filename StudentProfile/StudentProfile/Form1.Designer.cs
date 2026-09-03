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
            SuspendLayout();
            // 
            // lblGitHubBeginnerLab
            // 
            lblGitHubBeginnerLab.AutoSize = true;
            lblGitHubBeginnerLab.Location = new Point(301, 159);
            lblGitHubBeginnerLab.Name = "lblGitHubBeginnerLab";
            lblGitHubBeginnerLab.Size = new Size(175, 25);
            lblGitHubBeginnerLab.TabIndex = 0;
            lblGitHubBeginnerLab.Text = "GitHub Beginner Lab";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGitHubBeginnerLab);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGitHubBeginnerLab;
    }
}
