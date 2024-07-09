using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraryClockUI
{
    public class HoverUtils
    {
        public static void SetHoverImages(Label label, Image DefaultImage, Image HoverImage)
        {
            label.MouseEnter += delegate { ChangeImage(label, HoverImage); };
            label.MouseLeave += delegate { ChangeImage(label, DefaultImage); };
        }

        private static void ChangeImage(Label label, Image image)
        {
            label.Image = ImageUtils.ScaleImage(image, label.Width, label.Height);
        }
    }
}
