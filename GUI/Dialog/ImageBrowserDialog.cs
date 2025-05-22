using System;
using System.Drawing;
using System.Linq;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GUI {
    public partial class ImageBrowserDialog : Form {
        public SelectedImage SelectedImage { get; set; }

        public ImageBrowserDialog(){
            InitializeComponent();

            var imageExtensions = string.Join(";", ImageCodecInfo.GetImageDecoders().Select(ici => ici.FilenameExtension));
            OpenFileDialog.Filter = string.Format("Images|{0}|All Files|*.*", imageExtensions);
        }

        private void DragDropPanel_DragEnter(object sender, DragEventArgs e){
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Copy;

                DragDropPanel.BackColor = Color.FromArgb(55, 55, 55);
            }
        }
        private void DragDropPanel_DragLeave(object sender, EventArgs e){
            DragDropPanel.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void DragDropPanel_DragDrop(object sender, DragEventArgs e){
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            if (files.Length != 1) return;

            try {
                SelectedImage = files[0];
            } catch {
                DialogFactory.ShowIncorrectImageFormat();
                return;
            }

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e){
            OpenFileDialog.ShowDialog();

            if (string.IsNullOrEmpty(OpenFileDialog.FileName)) return;

            try {
                SelectedImage = OpenFileDialog.FileName;
            } catch {
                DialogFactory.ShowIncorrectImageFormat();
                return;
            }

            Close();
        }
    }
}
