namespace CSC_Alt_EZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LocateExeButton = new System.Windows.Forms.Button();
            this.MakeFilesButton = new System.Windows.Forms.Button();
            this.OpenFileD = new System.Windows.Forms.OpenFileDialog();
            this.OutputFolderButton = new System.Windows.Forms.Button();
            this.OutputFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderBrowserD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(704, 167);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // ExeTextBox
            // 
            this.ExeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExeTextBox.Location = new System.Drawing.Point(98, 185);
            this.ExeTextBox.Name = "ExeTextBox";
            this.ExeTextBox.Size = new System.Drawing.Size(586, 23);
            this.ExeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CSC exe file";
            // 
            // LocateExeButton
            // 
            this.LocateExeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LocateExeButton.Location = new System.Drawing.Point(690, 185);
            this.LocateExeButton.Name = "LocateExeButton";
            this.LocateExeButton.Size = new System.Drawing.Size(25, 23);
            this.LocateExeButton.TabIndex = 4;
            this.LocateExeButton.Text = "...";
            this.LocateExeButton.UseVisualStyleBackColor = true;
            this.LocateExeButton.Click += new System.EventHandler(this.LocateExeButton_Click);
            // 
            // MakeFilesButton
            // 
            this.MakeFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeFilesButton.Location = new System.Drawing.Point(603, 243);
            this.MakeFilesButton.Name = "MakeFilesButton";
            this.MakeFilesButton.Size = new System.Drawing.Size(113, 23);
            this.MakeFilesButton.TabIndex = 4;
            this.MakeFilesButton.Text = "Make EZ Files";
            this.MakeFilesButton.UseVisualStyleBackColor = true;
            this.MakeFilesButton.Click += new System.EventHandler(this.MakeFilesButton_Click);
            // 
            // OutputFolderButton
            // 
            this.OutputFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderButton.Location = new System.Drawing.Point(690, 214);
            this.OutputFolderButton.Name = "OutputFolderButton";
            this.OutputFolderButton.Size = new System.Drawing.Size(25, 23);
            this.OutputFolderButton.TabIndex = 4;
            this.OutputFolderButton.Text = "...";
            this.OutputFolderButton.UseVisualStyleBackColor = true;
            this.OutputFolderButton.Click += new System.EventHandler(this.OutputFolderButton_Click);
            // 
            // OutputFolderTextBox
            // 
            this.OutputFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFolderTextBox.Location = new System.Drawing.Point(98, 214);
            this.OutputFolderTextBox.Name = "OutputFolderTextBox";
            this.OutputFolderTextBox.Size = new System.Drawing.Size(586, 23);
            this.OutputFolderTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputFolderTextBox);
            this.Controls.Add(this.OutputFolderButton);
            this.Controls.Add(this.MakeFilesButton);
            this.Controls.Add(this.LocateExeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExeTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZ CSC Alt Startup Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ExeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LocateExeButton;
        private System.Windows.Forms.Button MakeFilesButton;
        private System.Windows.Forms.OpenFileDialog OpenFileD;
        private System.Windows.Forms.Button OutputFolderButton;
        private System.Windows.Forms.TextBox OutputFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserD;
    }
}

