namespace DirectoryParser
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDirStart = new System.Windows.Forms.Button();
            this.textDirStart = new System.Windows.Forms.TextBox();
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDirStart
            // 
            this.btnDirStart.Location = new System.Drawing.Point(21, 69);
            this.btnDirStart.Name = "btnDirStart";
            this.btnDirStart.Size = new System.Drawing.Size(110, 23);
            this.btnDirStart.TabIndex = 0;
            this.btnDirStart.Text = "Choose Directory";
            this.btnDirStart.UseVisualStyleBackColor = true;
            this.btnDirStart.Click += new System.EventHandler(this.btnDirStart_Click);
            // 
            // textDirStart
            // 
            this.textDirStart.Location = new System.Drawing.Point(137, 71);
            this.textDirStart.Name = "textDirStart";
            this.textDirStart.Size = new System.Drawing.Size(426, 20);
            this.textDirStart.TabIndex = 1;
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartSearch.Location = new System.Drawing.Point(21, 151);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(110, 23);
            this.btnStartSearch.TabIndex = 2;
            this.btnStartSearch.Text = "Start Search";
            this.btnStartSearch.UseVisualStyleBackColor = true;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(137, 153);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutput.Size = new System.Drawing.Size(625, 274);
            this.textOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.btnStartSearch);
            this.Controls.Add(this.textDirStart);
            this.Controls.Add(this.btnDirStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDirStart;
        private System.Windows.Forms.TextBox textDirStart;
        private System.Windows.Forms.Button btnStartSearch;
        private System.Windows.Forms.TextBox textOutput;
    }
}

