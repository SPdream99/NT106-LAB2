namespace Lab2
{
    partial class Lab02_Bai06
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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.NumABox = new System.Windows.Forms.TextBox();
            this.NumA = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.FirstFormula = new System.Windows.Forms.Label();
            this.FirstFormulaBox = new System.Windows.Forms.TextBox();
            this.NumBBox = new System.Windows.Forms.TextBox();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Gray;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Location = new System.Drawing.Point(426, 329);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 61);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.Text = "Xóa";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(288, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(283, 40);
            this.Title.TabIndex = 1;
            this.Title.Text = "Hôm nay ăn gì?";
            // 
            // NumABox
            // 
            this.NumABox.Location = new System.Drawing.Point(159, 179);
            this.NumABox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumABox.Name = "NumABox";
            this.NumABox.Size = new System.Drawing.Size(193, 26);
            this.NumABox.TabIndex = 2;
            // 
            // NumA
            // 
            this.NumA.AutoSize = true;
            this.NumA.Location = new System.Drawing.Point(53, 186);
            this.NumA.Name = "NumA";
            this.NumA.Size = new System.Drawing.Size(69, 20);
            this.NumA.TabIndex = 3;
            this.NumA.Text = "Món mới";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Gray;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExitButton.Location = new System.Drawing.Point(663, 329);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 61);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Gray;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CalculateButton.Location = new System.Drawing.Point(186, 329);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(116, 61);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Thêm";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.FirstFormula);
            this.ResultGroup.Controls.Add(this.FirstFormulaBox);
            this.ResultGroup.Location = new System.Drawing.Point(32, 566);
            this.ResultGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultGroup.Size = new System.Drawing.Size(508, 115);
            this.ResultGroup.TabIndex = 15;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "KẾT QUẢ";
            // 
            // FirstFormula
            // 
            this.FirstFormula.AutoSize = true;
            this.FirstFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstFormula.Location = new System.Drawing.Point(6, 45);
            this.FirstFormula.Name = "FirstFormula";
            this.FirstFormula.Size = new System.Drawing.Size(139, 29);
            this.FirstFormula.TabIndex = 17;
            this.FirstFormula.Text = "Hôm nay ăn";
            // 
            // FirstFormulaBox
            // 
            this.FirstFormulaBox.Location = new System.Drawing.Point(240, 45);
            this.FirstFormulaBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstFormulaBox.Name = "FirstFormulaBox";
            this.FirstFormulaBox.ReadOnly = true;
            this.FirstFormulaBox.Size = new System.Drawing.Size(193, 26);
            this.FirstFormulaBox.TabIndex = 16;
            // 
            // NumBBox
            // 
            this.NumBBox.Location = new System.Drawing.Point(385, 179);
            this.NumBBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumBBox.Multiline = true;
            this.NumBBox.Name = "NumBBox";
            this.NumBBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumBBox.Size = new System.Drawing.Size(471, 135);
            this.NumBBox.TabIndex = 10;
            // 
            // Lab02_Bai06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 754);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.NumBBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NumA);
            this.Controls.Add(this.NumABox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RemoveButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab02_Bai06";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox NumABox;
        private System.Windows.Forms.Label NumA;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Label FirstFormula;
        private System.Windows.Forms.TextBox FirstFormulaBox;
        private System.Windows.Forms.TextBox NumBBox;
    }
}

