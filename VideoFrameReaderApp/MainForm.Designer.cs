namespace VideoFrameReaderApp
{
    partial class MainForm
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnGenerateFrame = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(40, 32);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(116, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload Video";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(175, 31);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(336, 23);
            this.txtSource.TabIndex = 1;
            // 
            // btnGenerateFrame
            // 
            this.btnGenerateFrame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerateFrame.Location = new System.Drawing.Point(279, 125);
            this.btnGenerateFrame.Name = "btnGenerateFrame";
            this.btnGenerateFrame.Size = new System.Drawing.Size(116, 23);
            this.btnGenerateFrame.TabIndex = 2;
            this.btnGenerateFrame.Text = "Generate Frame";
            this.btnGenerateFrame.UseVisualStyleBackColor = false;
            this.btnGenerateFrame.Click += new System.EventHandler(this.btnGenerateFrame_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(40, 172);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 16);
            this.progressBar.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGenerateFrame);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnUpload);
            this.Name = "MainForm";
            this.Text = "Video Frame Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnGenerateFrame;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

