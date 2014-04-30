using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace CardGen
{
    public class Card
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Template Template = new Template();

        public string ArtUrl { get; set; }

        public Bitmap Art { get; set; }

        public Point ArtPos { get; set; }

        public Size FullCardSize = new Size(180, 250);

        public Card()
        {
            Art = new Bitmap(192, 192);
            Template.Front = new Bitmap(FullCardSize.Width, FullCardSize.Height);
        }

        public Bitmap FullCard
        {
            get
            {
                Bitmap b = new Bitmap(FullCardSize.Width, FullCardSize.Height);
                Graphics g = Graphics.FromImage(b);

                Art.MakeTransparent();
                Template.Front.MakeTransparent();

                g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                g.FillRectangle(Brushes.Black, new Rectangle(0, 0, FullCardSize.Width, FullCardSize.Height));

                ImageAttributes att = new ImageAttributes();

                g.DrawImage(Art, ArtPos.X, ArtPos.Y, Art.Width, Art.Height);

                g.DrawImage(Template.Front, 0, 0, FullCardSize.Width, FullCardSize.Height);

                StringFormat titleFormat = new StringFormat();
                titleFormat.Alignment = StringAlignment.Center;
                titleFormat.LineAlignment = StringAlignment.Near;
                g.DrawString(Name, Template.NameFont, Brushes.White, new RectangleF(10, 10, 160, 230), titleFormat);

                StringFormat descFormat = new StringFormat();
                descFormat.Alignment = StringAlignment.Near;
                descFormat.LineAlignment = StringAlignment.Near;
                g.DrawString(Description, Template.DescriptionFont, Brushes.White, new RectangleF(10, 160, 160, 90), descFormat);

                return b;
            }
        }
    }
}
