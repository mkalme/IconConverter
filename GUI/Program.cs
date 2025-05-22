using System;
using System.Windows.Forms;

namespace GUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SelectedImage selectedImage;

            if (args.Length < 1) {
                var dialog = DialogFactory.ShowImageBrowserDialog();
                selectedImage = dialog.SelectedImage;
            } else {
                try {
                    selectedImage = args[0];
                } catch {
                    DialogFactory.ShowIncorrectImageFormat();
                    return;
                }
            }

            if (selectedImage == null) return;

            Application.Run(new ConvertOptionsDialog(selectedImage));
        }
    }
}
