using System.Drawing.Drawing2D;

namespace HoraryClockUI
{
    public class ImageUtils
    {
        public static Image ScaleImage(Image originalImage, int newWidth, int newHeight)
        {
            Bitmap scaledImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(scaledImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return scaledImage;
        }

        public static Image ScaleImage(Image originalImage, double newWidth, double newHeight)
        {
            int newHeightInt = (int)newHeight;
            int newWidthInt = (int)newWidth;
            Bitmap scaledImage = new Bitmap(newWidthInt, newHeightInt);
            using (Graphics graphics = Graphics.FromImage(scaledImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, newWidthInt, newHeightInt);
            }

            return scaledImage;
        }
    }
}
