namespace Lab2
{
    partial class Lab02_Bai02
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
            this.ImportButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.EditorBox = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.GroupBox();
            this.Output = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.FileManager = new System.Windows.Forms.GroupBox();
            this.FileInfo = new System.Windows.Forms.GroupBox();
            this.Editor = new System.Windows.Forms.GroupBox();
            this.ProgramContent = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LineCount = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WordsCount = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CharacterCount = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Size.SuspendLayout();
            this.Output.SuspendLayout();
            this.Buttons.SuspendLayout();
            this.FileManager.SuspendLayout();
            this.FileInfo.SuspendLayout();
            this.Editor.SuspendLayout();
            this.ProgramContent.SuspendLayout();
            this.Url.SuspendLayout();
            this.LineCount.SuspendLayout();
            this.WordsCount.SuspendLayout();
            this.CharacterCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.Gray;
            this.ImportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ImportButton.Location = new System.Drawing.Point(3, 23);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(153, 68);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Đọc";
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(17, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(189, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Phần mềm đọc file";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(6, 25);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.ReadOnly = true;
            this.InputBox.Size = new System.Drawing.Size(273, 31);
            this.InputBox.TabIndex = 2;
            // 
            // EditorBox
            // 
            this.EditorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorBox.Location = new System.Drawing.Point(3, 23);
            this.EditorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditorBox.Multiline = true;
            this.EditorBox.Name = "EditorBox";
            this.EditorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EditorBox.Size = new System.Drawing.Size(540, 577);
            this.EditorBox.TabIndex = 6;
            // 
            // Size
            // 
            this.Size.Controls.Add(this.InputBox);
            this.Size.Dock = System.Windows.Forms.DockStyle.Top;
            this.Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(3, 92);
            this.Size.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Size.Name = "Size";
            this.Size.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Size.Size = new System.Drawing.Size(320, 88);
            this.Size.TabIndex = 8;
            this.Size.TabStop = false;
            this.Size.Text = "Size";
            this.Size.Enter += new System.EventHandler(this.Input_Enter);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.OutputBox);
            this.Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(3, 23);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Output.Size = new System.Drawing.Size(320, 69);
            this.Output.TabIndex = 9;
            this.Output.TabStop = false;
            this.Output.Text = "Tên File đọc";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(6, 25);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(273, 31);
            this.OutputBox.TabIndex = 2;
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.ExitButton);
            this.Buttons.Controls.Add(this.ImportButton);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons.Location = new System.Drawing.Point(3, 505);
            this.Buttons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buttons.Name = "Buttons";
            this.Buttons.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buttons.Size = new System.Drawing.Size(326, 95);
            this.Buttons.TabIndex = 11;
            this.Buttons.TabStop = false;
            // 
            // FileManager
            // 
            this.FileManager.Controls.Add(this.FileInfo);
            this.FileManager.Controls.Add(this.Buttons);
            this.FileManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileManager.Location = new System.Drawing.Point(11, 31);
            this.FileManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileManager.Name = "FileManager";
            this.FileManager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileManager.Size = new System.Drawing.Size(332, 604);
            this.FileManager.TabIndex = 12;
            this.FileManager.TabStop = false;
            // 
            // FileInfo
            // 
            this.FileInfo.Controls.Add(this.CharacterCount);
            this.FileInfo.Controls.Add(this.WordsCount);
            this.FileInfo.Controls.Add(this.LineCount);
            this.FileInfo.Controls.Add(this.Url);
            this.FileInfo.Controls.Add(this.Size);
            this.FileInfo.Controls.Add(this.Output);
            this.FileInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileInfo.Location = new System.Drawing.Point(3, 23);
            this.FileInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileInfo.Name = "FileInfo";
            this.FileInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileInfo.Size = new System.Drawing.Size(326, 499);
            this.FileInfo.TabIndex = 14;
            this.FileInfo.TabStop = false;
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.EditorBox);
            this.Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editor.Location = new System.Drawing.Point(343, 31);
            this.Editor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Editor.Size = new System.Drawing.Size(546, 604);
            this.Editor.TabIndex = 13;
            this.Editor.TabStop = false;
            this.Editor.Text = "Trình đọc file";
            // 
            // ProgramContent
            // 
            this.ProgramContent.AutoSize = true;
            this.ProgramContent.Controls.Add(this.Editor);
            this.ProgramContent.Controls.Add(this.Title);
            this.ProgramContent.Controls.Add(this.FileManager);
            this.ProgramContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramContent.Location = new System.Drawing.Point(0, 0);
            this.ProgramContent.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ProgramContent.Name = "ProgramContent";
            this.ProgramContent.Padding = new System.Windows.Forms.Padding(11, 12, 11, 62);
            this.ProgramContent.Size = new System.Drawing.Size(900, 697);
            this.ProgramContent.TabIndex = 14;
            this.ProgramContent.TabStop = false;
            this.ProgramContent.Enter += new System.EventHandler(this.ProgramContent_Enter);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(162, 23);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(161, 68);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // Url
            // 
            this.Url.Controls.Add(this.textBox1);
            this.Url.Dock = System.Windows.Forms.DockStyle.Top;
            this.Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Url.Location = new System.Drawing.Point(3, 180);
            this.Url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Url.Name = "Url";
            this.Url.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Url.Size = new System.Drawing.Size(320, 88);
            this.Url.TabIndex = 10;
            this.Url.TabStop = false;
            this.Url.Text = "Url";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 31);
            this.textBox1.TabIndex = 2;
            // 
            // LineCount
            // 
            this.LineCount.Controls.Add(this.textBox2);
            this.LineCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineCount.Location = new System.Drawing.Point(3, 268);
            this.LineCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LineCount.Name = "LineCount";
            this.LineCount.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LineCount.Size = new System.Drawing.Size(320, 88);
            this.LineCount.TabIndex = 11;
            this.LineCount.TabStop = false;
            this.LineCount.Text = "Line Count";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 25);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(273, 31);
            this.textBox2.TabIndex = 2;
            // 
            // WordsCount
            // 
            this.WordsCount.Controls.Add(this.textBox3);
            this.WordsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsCount.Location = new System.Drawing.Point(3, 356);
            this.WordsCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WordsCount.Name = "WordsCount";
            this.WordsCount.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WordsCount.Size = new System.Drawing.Size(320, 77);
            this.WordsCount.TabIndex = 12;
            this.WordsCount.TabStop = false;
            this.WordsCount.Text = "Words Count";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 25);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(273, 31);
            this.textBox3.TabIndex = 2;
            // 
            // CharacterCount
            // 
            this.CharacterCount.Controls.Add(this.textBox4);
            this.CharacterCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.CharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterCount.Location = new System.Drawing.Point(3, 433);
            this.CharacterCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CharacterCount.Name = "CharacterCount";
            this.CharacterCount.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CharacterCount.Size = new System.Drawing.Size(320, 69);
            this.CharacterCount.TabIndex = 13;
            this.CharacterCount.TabStop = false;
            this.CharacterCount.Text = "Character Count";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 25);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(273, 31);
            this.textBox4.TabIndex = 2;
            // 
            // Lab02_Bai02
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 697);
            this.Controls.Add(this.ProgramContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab02_Bai02";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Size.ResumeLayout(false);
            this.Size.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.Buttons.ResumeLayout(false);
            this.FileManager.ResumeLayout(false);
            this.FileInfo.ResumeLayout(false);
            this.Editor.ResumeLayout(false);
            this.Editor.PerformLayout();
            this.ProgramContent.ResumeLayout(false);
            this.ProgramContent.PerformLayout();
            this.Url.ResumeLayout(false);
            this.Url.PerformLayout();
            this.LineCount.ResumeLayout(false);
            this.LineCount.PerformLayout();
            this.WordsCount.ResumeLayout(false);
            this.WordsCount.PerformLayout();
            this.CharacterCount.ResumeLayout(false);
            this.CharacterCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox EditorBox;
        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.GroupBox FileManager;
        private System.Windows.Forms.GroupBox Editor;
        private System.Windows.Forms.GroupBox ProgramContent;
        private System.Windows.Forms.GroupBox FileInfo;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox WordsCount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox LineCount;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox Url;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox CharacterCount;
        private System.Windows.Forms.TextBox textBox4;
    }
}

