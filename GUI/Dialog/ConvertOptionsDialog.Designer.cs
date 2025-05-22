namespace GUI {
    partial class ConvertOptionsDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertOptionsDialog));
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.WidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SavedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(5, 5);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(70, 70);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePanel.Controls.Add(this.ImagePictureBox);
            this.ImagePanel.Location = new System.Drawing.Point(12, 12);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(80, 80);
            this.ImagePanel.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ConvertButton.Location = new System.Drawing.Point(12, 113);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(80, 23);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // WidthUpDown
            // 
            this.WidthUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WidthUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.WidthUpDown.Location = new System.Drawing.Point(110, 31);
            this.WidthUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.WidthUpDown.Name = "WidthUpDown";
            this.WidthUpDown.Size = new System.Drawing.Size(54, 20);
            this.WidthUpDown.TabIndex = 4;
            this.WidthUpDown.ValueChanged += new System.EventHandler(this.WidthUpDown_ValueChanged);
            // 
            // HeightUpDown
            // 
            this.HeightUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.HeightUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HeightUpDown.Location = new System.Drawing.Point(170, 31);
            this.HeightUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.HeightUpDown.Name = "HeightUpDown";
            this.HeightUpDown.Size = new System.Drawing.Size(54, 20);
            this.HeightUpDown.TabIndex = 5;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.WidthLabel.Location = new System.Drawing.Point(106, 15);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HeightLabel.Location = new System.Drawing.Point(167, 15);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Height";
            // 
            // AspectRatioCheckBox
            // 
            this.AspectRatioCheckBox.AutoSize = true;
            this.AspectRatioCheckBox.Checked = true;
            this.AspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AspectRatioCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AspectRatioCheckBox.Location = new System.Drawing.Point(110, 60);
            this.AspectRatioCheckBox.Name = "AspectRatioCheckBox";
            this.AspectRatioCheckBox.Size = new System.Drawing.Size(109, 17);
            this.AspectRatioCheckBox.TabIndex = 8;
            this.AspectRatioCheckBox.Text = "Keep aspect ratio";
            this.AspectRatioCheckBox.UseVisualStyleBackColor = true;
            this.AspectRatioCheckBox.CheckedChanged += new System.EventHandler(this.AspectRatioCheckBox_CheckedChanged);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Icon (*.ico)|*ico";
            // 
            // SavedLabel
            // 
            this.SavedLabel.AutoSize = true;
            this.SavedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SavedLabel.Location = new System.Drawing.Point(110, 118);
            this.SavedLabel.Name = "SavedLabel";
            this.SavedLabel.Size = new System.Drawing.Size(0, 13);
            this.SavedLabel.TabIndex = 9;
            // 
            // ConvertOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(431, 151);
            this.Controls.Add(this.SavedLabel);
            this.Controls.Add(this.AspectRatioCheckBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightUpDown);
            this.Controls.Add(this.WidthUpDown);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ImagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConvertOptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert";
            this.Shown += new System.EventHandler(this.ConvertOptionsDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.NumericUpDown WidthUpDown;
        private System.Windows.Forms.NumericUpDown HeightUpDown;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.CheckBox AspectRatioCheckBox;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label SavedLabel;
    }
}