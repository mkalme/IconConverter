using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using IconConverter;

namespace GUI {
    public partial class ConvertOptionsDialog : Form {
        private SelectedImage SelectedImage { get; set; }
        private Size SelectedSize {
            get => new Size((int)WidthUpDown.Value, (int)HeightUpDown.Value);
        }

        public ConvertOptionsDialog(SelectedImage selectedImage){
            InitializeComponent();

            SelectedImage = selectedImage;

            SaveFileDialog.InitialDirectory = Path.GetDirectoryName(SelectedImage.ImagePath);
            SaveFileDialog.FileName = SelectedImage.NewName;

            Display();
        }

        private void ConvertOptionsDialog_Shown(object sender, EventArgs e){
            BringToFront();
        }

        private void Display() {
            ImagePictureBox.Image = SelectedImage.Image;

            HeightUpDown.Enabled = !AspectRatioCheckBox.Checked;

            SetSize(SelectedImage.Image.Width);
        }
        private void SetSize(int width) {
            WidthUpDown.Value = FixSize(width, (int)WidthUpDown.Maximum);

            if (AspectRatioCheckBox.Checked) {
                HeightUpDown.Value = FixSize((int)((double)SelectedImage.Image.Height / SelectedImage.Image.Width * (int)WidthUpDown.Value),
                    (int)HeightUpDown.Maximum);
            }
        }
        private static int FixSize(int size, int maxSize) {
            return Math.Min(size, maxSize);
        }

        private void WidthUpDown_ValueChanged(object sender, EventArgs e){
            SetSize((int)WidthUpDown.Value);
        }
        private void AspectRatioCheckBox_CheckedChanged(object sender, EventArgs e){
            HeightUpDown.Enabled = !AspectRatioCheckBox.Checked;

            SetSize((int)WidthUpDown.Value);
        }

        private void ConvertButton_Click(object sender, EventArgs e){
            byte[] byteArray;

            try {
                byteArray = IconConvert.IconToByteArray(SelectedImage.Image, SelectedSize, AspectRatioCheckBox.Checked);
            } catch {
                DialogFactory.ShowCouldNotConvertToIcon();
                return;
            }

            SaveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(SaveFileDialog.FileName)) {
                try {
                    File.WriteAllBytes(SaveFileDialog.FileName, byteArray);
                    SavedLabel.Text = "Saved";
                } catch{
                    DialogFactory.ShowCouldNotSaveIcon();
                }
            }
        }
    }
}
