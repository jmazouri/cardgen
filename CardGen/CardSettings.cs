using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGen
{
    public class CardSettings
    {
        public Font NameFont { get; set; }
        public Font DescriptionFont { get; set; }
        public Bitmap Front { get; set; }

        public CardSettings()
        {
            NameFont = new Font("Arial", 14);
            DescriptionFont = new Font("Arial", 12);
            Front = new Bitmap(1, 1);
        }
    }
}
