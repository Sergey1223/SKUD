namespace TestTask
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.originalFileButton = new System.Windows.Forms.Button();
            this.resultFileButton = new System.Windows.Forms.Button();
            this.originalFileLabel = new System.Windows.Forms.Label();
            this.resultFileLabel = new System.Windows.Forms.Label();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.originalFileNameLabel = new System.Windows.Forms.Label();
            this.resultFileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Text File";
            this.openFileDialog.Filter = "Text files|*.txt";
            // 
            // originalFileButton
            // 
            this.originalFileButton.Location = new System.Drawing.Point(12, 106);
            this.originalFileButton.Name = "originalFileButton";
            this.originalFileButton.Size = new System.Drawing.Size(75, 23);
            this.originalFileButton.TabIndex = 0;
            this.originalFileButton.Text = "Open";
            this.originalFileButton.UseVisualStyleBackColor = true;
            this.originalFileButton.Click += new System.EventHandler(this.OpenOriginalFileButton_Click);
            // 
            // resultFileButton
            // 
            this.resultFileButton.Location = new System.Drawing.Point(299, 106);
            this.resultFileButton.Name = "resultFileButton";
            this.resultFileButton.Size = new System.Drawing.Size(75, 23);
            this.resultFileButton.TabIndex = 1;
            this.resultFileButton.Text = "Open";
            this.resultFileButton.UseVisualStyleBackColor = true;
            this.resultFileButton.Click += new System.EventHandler(this.OpenResultFileButton_Click);
            // 
            // originalFileLabel
            // 
            this.originalFileLabel.AutoSize = true;
            this.originalFileLabel.Location = new System.Drawing.Point(9, 69);
            this.originalFileLabel.Name = "originalFileLabel";
            this.originalFileLabel.Size = new System.Drawing.Size(64, 13);
            this.originalFileLabel.TabIndex = 2;
            this.originalFileLabel.Text = "Original File:";
            // 
            // resultFileLabel
            // 
            this.resultFileLabel.AutoSize = true;
            this.resultFileLabel.Location = new System.Drawing.Point(296, 69);
            this.resultFileLabel.Name = "resultFileLabel";
            this.resultFileLabel.Size = new System.Drawing.Size(59, 13);
            this.resultFileLabel.TabIndex = 3;
            this.resultFileLabel.Text = "Result File:";
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputRichTextBox.Location = new System.Drawing.Point(15, 208);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(457, 335);
            this.outputRichTextBox.TabIndex = 4;
            this.outputRichTextBox.Text = "";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.analyzeButton.Enabled = false;
            this.analyzeButton.Location = new System.Drawing.Point(156, 170);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(75, 23);
            this.analyzeButton.TabIndex = 5;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // originalFileNameLabel
            // 
            this.originalFileNameLabel.AutoSize = true;
            this.originalFileNameLabel.Location = new System.Drawing.Point(79, 69);
            this.originalFileNameLabel.Name = "originalFileNameLabel";
            this.originalFileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.originalFileNameLabel.TabIndex = 6;
            // 
            // resultFileNameLabel
            // 
            this.resultFileNameLabel.AutoSize = true;
            this.resultFileNameLabel.Location = new System.Drawing.Point(361, 69);
            this.resultFileNameLabel.Name = "resultFileNameLabel";
            this.resultFileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.resultFileNameLabel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 555);
            this.Controls.Add(this.resultFileNameLabel);
            this.Controls.Add(this.originalFileNameLabel);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.resultFileLabel);
            this.Controls.Add(this.originalFileLabel);
            this.Controls.Add(this.resultFileButton);
            this.Controls.Add(this.originalFileButton);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "TestTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button originalFileButton;
        private System.Windows.Forms.Button resultFileButton;
        private System.Windows.Forms.Label originalFileLabel;
        private System.Windows.Forms.Label resultFileLabel;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.Label originalFileNameLabel;
        private System.Windows.Forms.Label resultFileNameLabel;
    }
}

