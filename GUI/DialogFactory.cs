using System;
using System.Windows.Forms;

namespace GUI {
    public class DialogFactory {
        public static ImageBrowserDialog ShowImageBrowserDialog() {
            ImageBrowserDialog dialog = new ImageBrowserDialog();
            dialog.ShowDialog();

            return dialog;
        }

        public static void ShowIncorrectImageFormat() {
            MessageBox.Show("Incorrect image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowCouldNotConvertToIcon(){
            MessageBox.Show("Couldn't convert to icon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowCouldNotSaveIcon() {
            MessageBox.Show("Couldn't save icon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
