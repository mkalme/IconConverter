using System;
using System.IO;
using System.Drawing;

namespace GUI {
    public class SelectedImage {
        public Image Image { get; set; }
        public string ImagePath { get; set; }

        public string NewName {
            get => $"{Path.GetFileNameWithoutExtension(ImagePath)}.ico";
        }

        public SelectedImage(Image image, string path) {
            Image = image;
            ImagePath = path;
        }

        public static implicit operator SelectedImage(string path) {
            return new SelectedImage(Image.FromFile(path), path);
        }
    }
}
