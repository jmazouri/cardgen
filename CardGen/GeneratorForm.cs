using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGen
{
    public partial class GeneratorForm : Form
    {
        public Card CurrentCard = new Card();

        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            ArtPosX.Value = ArtPositionSelector.ExactPosition.X;
            ArtPosY.Value = ArtPositionSelector.ExactPosition.Y;
            ImageScale.Value = (decimal)ArtPositionSelector.ImageSize;
            InfoChanged();
        }
        
        private void InfoChanged()
        {
            CardPreview.Image = (Image)CurrentCard.FullCard;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentCard.Name = CardName.Text;
            InfoChanged();
        }

        private void BrowseArt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ArtPath.Text = openFileDialog1.FileName;
            }
        }

        private void BrowseOverlay_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OverlayPath.Text = openFileDialog1.FileName;
            }
        }

        private void ArtPath_TextChanged(object sender, EventArgs e)
        {
            CurrentCard.Art = new Bitmap(ArtPath.Text);
            InfoChanged();
        }

        private void OverlayPath_TextChanged(object sender, EventArgs e)
        {
            CurrentCard.Front = new Bitmap(OverlayPath.Text);
            InfoChanged();
        }
        
        private void UpdateArt()
        {
            try
            {
                Bitmap original = new Bitmap(ArtPath.Text);
                CurrentCard.Art = Util.ResizeBitmap(original, original.Width * ArtPositionSelector.ImageSize, original.Height * ArtPositionSelector.ImageSize);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Load some card art first!");
            }
        }

        private void ArtPositionSelector_OnChange(object sender, EventArgs e)
        {
            UpdateArt();
            
            CurrentCard.ArtPos = ArtPositionSelector.Position;

            ArtPosX.Value = ArtPositionSelector.ExactPosition.X;
            ArtPosY.Value = ArtPositionSelector.ExactPosition.Y;

            ImageScale.Value = (decimal)ArtPositionSelector.ImageSize;

            InfoChanged();
        }

        private void CardDesc_TextChanged(object sender, EventArgs e)
        {
            CurrentCard.Description = CardDesc.Text;
            InfoChanged();
        }

        private void ArtPosY_ValueChanged(object sender, EventArgs e)
        {
            ArtPositionSelector.ExactPosition = new Point(ArtPositionSelector.ExactPosition.X, (int)ArtPosY.Value);
            CurrentCard.ArtPos = ArtPositionSelector.Position;
            InfoChanged();
        }

        private void ArtPosX_ValueChanged(object sender, EventArgs e)
        {
            ArtPositionSelector.ExactPosition = new Point((int)ArtPosX.Value, ArtPositionSelector.ExactPosition.Y);
            CurrentCard.ArtPos = ArtPositionSelector.Position;
            InfoChanged();
        }

        private void ImageScale_ValueChanged(object sender, EventArgs e)
        {
            ArtPositionSelector.ImageSize = (double)ImageScale.Value;
            UpdateArt();
            InfoChanged();
        }
    }
}
