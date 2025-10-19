namespace Lab2
{
    partial class Lab02_Bai01
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
            this.Input = new System.Windows.Forms.GroupBox();
            this.Output = new System.Windows.Forms.GroupBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.FileManager = new System.Windows.Forms.GroupBox();
            this.FileNameInput = new System.Windows.Forms.GroupBox();
            this.Editor = new System.Windows.Forms.GroupBox();
            this.ProgramContent = new System.Windows.Forms.GroupBox();
            this.Input.SuspendLayout();
            this.Output.SuspendLayout();
            this.Buttons.SuspendLayout();
            this.FileManager.SuspendLayout();
            this.FileNameInput.SuspendLayout();
            this.Editor.SuspendLayout();
            this.ProgramContent.SuspendLayout();
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
            this.ImportButton.Text = "Nhập";
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(17, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Phần mềm đọc ghi file";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(86, 25);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(193, 31);
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
            this.EditorBox.Size = new System.Drawing.Size(540, 442);
            this.EditorBox.TabIndex = 6;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.InputBox);
            this.Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(3, 23);
            this.Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input.Size = new System.Drawing.Size(320, 69);
            this.Input.TabIndex = 8;
            this.Input.TabStop = false;
            this.Input.Text = "Tên File đọc";
            // 
            // Output
            // 
            this.Output.Controls.Add(this.OutputBox);
            this.Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(3, 126);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Output.Size = new System.Drawing.Size(320, 69);
            this.Output.TabIndex = 9;
            this.Output.TabStop = false;
            this.Output.Text = "Tên File ghi";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(86, 25);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(193, 31);
            this.OutputBox.TabIndex = 2;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Gray;
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExportButton.Location = new System.Drawing.Point(154, 23);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(169, 68);
            this.ExportButton.TabIndex = 10;
            this.ExportButton.Text = "Xuất";
            this.ExportButton.UseVisualStyleBackColor = false;
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.ExportButton);
            this.Buttons.Controls.Add(this.ImportButton);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons.Location = new System.Drawing.Point(3, 370);
            this.Buttons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buttons.Name = "Buttons";
            this.Buttons.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buttons.Size = new System.Drawing.Size(326, 95);
            this.Buttons.TabIndex = 11;
            this.Buttons.TabStop = false;
            // 
            // FileManager
            // 
            this.FileManager.Controls.Add(this.FileNameInput);
            this.FileManager.Controls.Add(this.Buttons);
            this.FileManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileManager.Location = new System.Drawing.Point(11, 31);
            this.FileManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileManager.Name = "FileManager";
            this.FileManager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileManager.Size = new System.Drawing.Size(332, 469);
            this.FileManager.TabIndex = 12;
            this.FileManager.TabStop = false;
            // 
            // FileNameInput
            // 
            this.FileNameInput.Controls.Add(this.Input);
            this.FileNameInput.Controls.Add(this.Output);
            this.FileNameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileNameInput.Location = new System.Drawing.Point(3, 23);
            this.FileNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileNameInput.Size = new System.Drawing.Size(326, 199);
            this.FileNameInput.TabIndex = 14;
            this.FileNameInput.TabStop = false;
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
            this.Editor.Text = "Trình chỉnh sửa file";
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
            this.ProgramContent.Size = new System.Drawing.Size(900, 562);
            this.ProgramContent.TabIndex = 14;
            this.ProgramContent.TabStop = false;
            // 
            // Lab02_Bai01
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.ProgramContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab02_Bai01";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.Output.ResumeLayout(false);
            this.Output.PerformLayout();
            this.Buttons.ResumeLayout(false);
            this.FileManager.ResumeLayout(false);
            this.FileNameInput.ResumeLayout(false);
            this.Editor.ResumeLayout(false);
            this.Editor.PerformLayout();
            this.ProgramContent.ResumeLayout(false);
            this.ProgramContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox EditorBox;
        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.GroupBox FileManager;
        private System.Windows.Forms.GroupBox Editor;
        private System.Windows.Forms.GroupBox ProgramContent;
        private System.Windows.Forms.GroupBox FileNameInput;
    }
}

