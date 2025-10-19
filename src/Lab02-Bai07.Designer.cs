namespace Lab2
{
    partial class Lab02_Bai07
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
            this.Title = new System.Windows.Forms.Label();
            this.EditorBox = new System.Windows.Forms.TextBox();
            this.FileManager = new System.Windows.Forms.GroupBox();
            this.Editor = new System.Windows.Forms.GroupBox();
            this.ProgramContent = new System.Windows.Forms.GroupBox();
            this.FileNameInput = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FileManager.SuspendLayout();
            this.Editor.SuspendLayout();
            this.ProgramContent.SuspendLayout();
            this.FileNameInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(226, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Phần mềm duyệt ổ đĩa";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditorBox
            // 
            this.EditorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorBox.Location = new System.Drawing.Point(3, 23);
            this.EditorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditorBox.Multiline = true;
            this.EditorBox.Name = "EditorBox";
            this.EditorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditorBox.Size = new System.Drawing.Size(540, 442);
            this.EditorBox.TabIndex = 6;
            // 
            // FileManager
            // 
            this.FileManager.Controls.Add(this.FileNameInput);
            this.FileManager.Controls.Add(this.Title);
            this.FileManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileManager.Location = new System.Drawing.Point(11, 31);
            this.FileManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileManager.Name = "FileManager";
            this.FileManager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileManager.Size = new System.Drawing.Size(332, 469);
            this.FileManager.TabIndex = 12;
            this.FileManager.TabStop = false;
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.EditorBox);
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.Location = new System.Drawing.Point(343, 31);
            this.Editor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Editor.Size = new System.Drawing.Size(546, 469);
            this.Editor.TabIndex = 13;
            this.Editor.TabStop = false;
            this.Editor.Text = "Trình chỉnh đọc file";
            // 
            // ProgramContent
            // 
            this.ProgramContent.AutoSize = true;
            this.ProgramContent.Controls.Add(this.Editor);
            this.ProgramContent.Controls.Add(this.FileManager);
            this.ProgramContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramContent.Location = new System.Drawing.Point(0, 0);
            this.ProgramContent.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ProgramContent.Name = "ProgramContent";
            this.ProgramContent.Padding = new System.Windows.Forms.Padding(11, 12, 11, 62);
            this.ProgramContent.Size = new System.Drawing.Size(900, 562);
            this.ProgramContent.TabIndex = 14;
            this.ProgramContent.TabStop = false;
            // 
            // FileNameInput
            // 
            this.FileNameInput.Controls.Add(this.listBox1);
            this.FileNameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileNameInput.Location = new System.Drawing.Point(3, 23);
            this.FileNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileNameInput.Size = new System.Drawing.Size(326, 442);
            this.FileNameInput.TabIndex = 14;
            this.FileNameInput.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 415);
            this.listBox1.TabIndex = 0;
            // 
            // Lab02_Bai07
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.ProgramContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab02_Bai07";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FileManager.ResumeLayout(false);
            this.FileManager.PerformLayout();
            this.Editor.ResumeLayout(false);
            this.Editor.PerformLayout();
            this.ProgramContent.ResumeLayout(false);
            this.FileNameInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox EditorBox;
        private System.Windows.Forms.GroupBox FileManager;
        private System.Windows.Forms.GroupBox Editor;
        private System.Windows.Forms.GroupBox ProgramContent;
        private System.Windows.Forms.GroupBox FileNameInput;
        private System.Windows.Forms.ListBox listBox1;
    }
}

