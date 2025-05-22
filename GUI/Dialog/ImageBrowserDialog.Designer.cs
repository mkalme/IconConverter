namespace GUI {
    partial class ImageBrowserDialog {
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBrowserDialog));
            this.DragDropPanel = new System.Windows.Forms.Panel();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SeperatorLabel = new System.Windows.Forms.Label();
            this.BrowseLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DragDropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DragDropPanel
            // 
            this.DragDropPanel.AllowDrop = true;
            this.DragDropPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DragDropPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DragDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragDropPanel.Controls.Add(this.ImagePictureBox);
            this.DragDropPanel.Controls.Add(this.DragDropLabel);
            this.DragDropPanel.Location = new System.Drawing.Point(12, 12);
            this.DragDropPanel.Name = "DragDropPanel";
            this.DragDropPanel.Size = new System.Drawing.Size(375, 183);
            this.DragDropPanel.TabIndex = 0;
            this.DragDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropPanel_DragDrop);
            this.DragDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropPanel_DragEnter);
            this.DragDropPanel.DragLeave += new System.EventHandler(this.DragDropPanel_DragLeave);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Image = global::GUI.Properties.Resources._128pxImage;
            this.ImagePictureBox.Location = new System.Drawing.Point(142, 62);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(90, 90);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 1;
            this.ImagePictureBox.TabStop = false;
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.AutoSize = true;
            this.DragDropLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DragDropLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DragDropLabel.Location = new System.Drawing.Point(100, 10);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(178, 25);
            this.DragDropLabel.TabIndex = 0;
            this.DragDropLabel.Text = "Drag and drop here";
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ConvertButton.Location = new System.Drawing.Point(162, 235);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Browse";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SeperatorLabel
            // 
            this.SeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SeperatorLabel.Location = new System.Drawing.Point(12, 206);
            this.SeperatorLabel.Name = "SeperatorLabel";
            this.SeperatorLabel.Size = new System.Drawing.Size(375, 1);
            this.SeperatorLabel.TabIndex = 3;
            // 
            // BrowseLabel
            // 
            this.BrowseLabel.AutoSize = true;
            this.BrowseLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseLabel.Location = new System.Drawing.Point(172, 217);
            this.BrowseLabel.Name = "BrowseLabel";
            this.BrowseLabel.Size = new System.Drawing.Size(55, 13);
            this.BrowseLabel.TabIndex = 4;
            this.BrowseLabel.Text = "Or browse";
            // 
            // ImageBrowserDialog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(399, 274);
            this.Controls.Add(this.BrowseLabel);
            this.Controls.Add(this.SeperatorLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.DragDropPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageBrowserDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image to icon";
            this.DragDropPanel.ResumeLayout(false);
            this.DragDropPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DragDropPanel;
        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label SeperatorLabel;
        private System.Windows.Forms.Label BrowseLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.PictureBox ImagePictureBox;
    }
}

