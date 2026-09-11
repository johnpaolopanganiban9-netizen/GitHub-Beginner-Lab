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
            SuspendLayout();
            // 
            // lblGitHubBeginnerLab
            // 
            lblGitHubBeginnerLab.AutoSize = true;
            lblGitHubBeginnerLab.Location = new Point(211, 95);
            lblGitHubBeginnerLab.Margin = new Padding(2, 0, 2, 0);
            lblGitHubBeginnerLab.Name = "lblGitHubBeginnerLab";
            lblGitHubBeginnerLab.Size = new Size(117, 15);
            lblGitHubBeginnerLab.TabIndex = 0;
            lblGitHubBeginnerLab.Text = "GitHub Beginner Lab";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 126);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 1;
            label1.Text = "Contact Number: 093450945";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(label1);
            Controls.Add(lblGitHubBeginnerLab);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGitHubBeginnerLab;
        private Label label1;
    }
}
