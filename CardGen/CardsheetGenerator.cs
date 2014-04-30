using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGen
{
    class CardsheetGenerator
    {
        public static Bitmap GenerateSheet(List<Card> Cards, Template Settings, int Width = 10)
        {
            if (!Cards.Any())
            {
                throw new ArgumentException();
            }

            Bitmap ret = new Bitmap(Cards.First().FullCardSize.Width * Width,
                Cards.First().FullCardSize.Height * ((Cards.Count / Width) + 1));

            Graphics g = Graphics.FromImage(ret);

            int xpos = 0;
            int ypos = 0;

            for (int i = 0; i < Cards.Count; i++)
            {
                Card cur = Cards[i];
                cur.Template = Settings;

                int w = cur.FullCardSize.Width;
                int h = cur.FullCardSize.Height;

                g.DrawImage(cur.FullCard, cur.FullCardSize.Width * xpos, cur.FullCardSize.Height * ypos, w, h);

                xpos++;

                if (xpos > Width)
                {
                    xpos = 0;
                    ypos++;
                }
            }

            return ret;

        }
    }
}
