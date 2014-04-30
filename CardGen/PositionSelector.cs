using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGen
{
    public partial class PositionSelector : Panel
    {
        private Point _exactpos;

        public Point ExactPosition
        {
            get
            {
                return _exactpos;
            }
            set
            {
                _exactpos = value;
                Invalidate();
            }
        }

        private double _imagesize = 1;

        public double ImageSize
        {
            get
            {
                return _imagesize;
            }
            set
            {
                _imagesize = value;
                Invalidate();
            }
        }

        public double PositionScale = 1.5;

        public Point Position
        {
            get
            {
                int newx = (int)Math.Round(((double)ExactPosition.X) * PositionScale);
                int newy = (int)Math.Round(((double)ExactPosition.Y) * PositionScale);

                return new Point(newx, newy);
            }
        }

        public delegate void myDataChangedDelegate(object sender, EventArgs e);
        public event myDataChangedDelegate OnChange;

        public PositionSelector()
        {
            ExactPosition = new Point((Width / 2) - (int)(8 * ImageSize), (Height / 2) - (int)(8 * ImageSize));
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(0, 0, Width, Height));

            e.Graphics.FillRectangle(Brushes.White, new Rectangle(ExactPosition, new Size((int)(16 * ImageSize), (int)(16 * ImageSize))));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(ExactPosition.X - 1, ExactPosition.Y - 1, (int)(16 * ImageSize), (int)(16 * ImageSize)));

            e.Graphics.DrawString(string.Format("{0},{1}", ExactPosition.X, ExactPosition.Y), new Font("Arial", 10), Brushes.Black, new PointF(0, Height - 16));
        }

        void MouseChange(MouseEventArgs e)
        {
            int newx = e.Location.X - (int)(8 * ImageSize);
            int newy = e.Location.Y - (int)(8 * ImageSize);

            ExactPosition = new Point(newx, newy);

            Invalidate();

            if (OnChange != null)
            {
                OnChange(this, new EventArgs());
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseChange(e);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseChange(e);
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            if (e.Delta > 0)
            {
                ImageSize += 0.05;
            }
            else
            {
                if (ImageSize - 0.05 > 0)
                {
                    ImageSize -= 0.05;
                }
            }

            Invalidate();
            MouseChange(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!Focused)
            {
                Focus();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (Focused)
            {
                Parent.Focus();
            }
        }
    }
}
