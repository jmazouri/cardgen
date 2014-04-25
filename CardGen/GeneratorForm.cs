using System;
using System.Drawing;
using System.Windows.Forms;

namespace CardGen
{
    public partial class GeneratorForm : Form
    {
        public Card CurrentCard = new Card();
        private Bitmap OriginalArt = new Bitmap(1, 1);

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
            CardPreview.Image = CurrentCard.FullCard;
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
            OriginalArt = new Bitmap(ArtPath.Text);
            CurrentCard.Art = OriginalArt;
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
                if (System.IO.File.Exists(ArtPath.Text))
                {
                    CurrentCard.Art = Util.ResizeBitmap(OriginalArt,
                        OriginalArt.Width * (int)(Math.Round(ArtPositionSelector.ImageSize)), 
                        OriginalArt.Height * (int)(Math.Round(ArtPositionSelector.ImageSize)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Image");
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

        private void setTitleFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = CurrentCard.NameFont;
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentCard.NameFont = fontDialog1.Font;
                InfoChanged();
            }
        }

        private void setDescriptionFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = CurrentCard.DescriptionFont;
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentCard.DescriptionFont = fontDialog1.Font;
                InfoChanged();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CurrentCard.FullCard.Save(saveFileDialog1.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not export image! Try again.");
                }
            }
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var processor = new BatchProcessor();
            processor.Show();
        }

        private void setTitleFontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fontDialog1.Font = CurrentCard.NameFont;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentCard.NameFont = fontDialog1.Font;
            }
        }

        private void setDescriptionFontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fontDialog1.Font = CurrentCard.DescriptionFont;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentCard.DescriptionFont = fontDialog1.Font;
            }
        }
    }
}
