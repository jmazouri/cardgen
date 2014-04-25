using System.Drawing;

namespace CardGen
{
    public class Util
    {
        public static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
        {
            using (var grD = Graphics.FromImage(destBitmap))
            {
                grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);
            }
        }

        public static Bitmap ResizeBitmap(Bitmap sourceBmp, int width, int height)
        {
            var result = new Bitmap(width, height);
            result.MakeTransparent();
            using (Graphics g = Graphics.FromImage(result))
                g.DrawImage(sourceBmp, 0, 0, width, height);
            return result;
        }
    }
}
