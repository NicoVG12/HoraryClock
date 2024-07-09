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

        public static void ScaleLabels(IEnumerable<Label> labels, double scaleRatio)
        {
            foreach (Label label in labels)
            {
                label.Size = new Size((int)(label.Width * scaleRatio), (int)(label.Height * scaleRatio));
                label.Location = new Point((int)(scaleRatio * label.Location.X), (int)(scaleRatio * label.Location.Y));

                if (label.Image != null)
                {
                    label.Image = ImageUtils.ScaleImage(label.Image, label.Width, label.Height);
                }
            }
        }
    }
}
