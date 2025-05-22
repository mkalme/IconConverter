using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace IconConverter
{
    public static class IconConvert{
        public static byte[] IconToByteArray(Image image, Size size, bool keepAspectRatio) {
            MemoryStream stream = new MemoryStream();
            ToIcon(image, size, stream, keepAspectRatio);

            return stream.ToArray();
        }
        private static void ToIcon(Image image, Size size, Stream outputStream, bool keepAspectRatio) {
            int width = size.Width;
            int height;

            if (keepAspectRatio) {
                height = (int)((double)image.Height / image.Width * size.Width);
            } else {
                height = size.Height;
            }

            MemoryStream stream = new MemoryStream();

            Bitmap bitmap = new Bitmap(image, width, height);
            bitmap.Save(stream, ImageFormat.Png);

            //Write
            BinaryWriter writer = new BinaryWriter(outputStream);

            writer.Write((byte)0);
            writer.Write((byte)0);

            writer.Write((short)1);
            writer.Write((short)1);

            //Image header
            writer.Write((byte)width);
            writer.Write((byte)height);

            writer.Write((byte)0);

            writer.Write((byte)0);

            writer.Write((short)0);

            writer.Write((short)32);
            writer.Write((int)stream.Length);

            writer.Write(22);

            writer.Write(stream.ToArray());

            writer.Flush();
        }
    }
}
