using System.Drawing;
using System.Drawing.Imaging;

namespace CardGen
{
    public class Card
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Font NameFont { get; set; }
        public Font DescriptionFont { get; set; }

        public Bitmap Art { get; set; }
        public Bitmap Front { get; set; }

        public Point ArtPos { get; set; }

        public Card()
        {
            Art = new Bitmap(192, 192);
            Front = new Bitmap(180, 250);

            NameFont = new Font("Arial", 14);
            DescriptionFont = new Font("Arial", 12);
        }

        public Bitmap FullCard
        {
            get
            {
                var b = new Bitmap(180, 250);
                var g = Graphics.FromImage(b);

                Art.MakeTransparent();
                Front.MakeTransparent();

                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 180, 250));

                var att = new ImageAttributes();

                g.DrawImage(Art, ArtPos.X, ArtPos.Y, Art.Width, Art.Height);

                g.DrawImage(Front, 0, 0, 180, 250);

                var titleFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };
                g.DrawString(Name, NameFont, Brushes.White, new RectangleF(10, 10, 160, 230), titleFormat);

                var descFormat = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Near
                };
                g.DrawString(Description, DescriptionFont, Brushes.White, new RectangleF(10, 160, 160, 90), descFormat);

                return b;
            }
        }
    }
}
