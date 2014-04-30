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
    public partial class BatchProcessor : Form
    {
        public Card CurCard = new Card();
        List<Card> ListOfCards = new List<Card>();
        Template CurSettings = new Template();

        GoogleSpreadsheetImportSettings GoogleSettings = new GoogleSpreadsheetImportSettings();

        public BatchProcessor()
        {
            InitializeComponent();
        }

        private void BatchProcessor_Load(object sender, EventArgs e)
        {
            OutputDirBox.Text = System.IO.Directory.GetCurrentDirectory();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImporterSelector.SelectedIndex == 0)
            {
                ImporterSettings.SelectedObject = GoogleSettings;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                OutputDirBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DoImport_Click(object sender, EventArgs e)
        {
            if (ImporterSelector.SelectedIndex == 0)
            {
                try
                {
                    ListOfCards = GoogleSpreadsheetImport.Import(GoogleSettings);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in loading google spreadsheet: " + ex.Message);
                }
            }

            CardList.Clear();

            CardList.Columns.Add("Name");
            CardList.Columns.Add("Description", 160);

            foreach (Card card in ListOfCards)
            {
                CardList.Items.Add(new ListViewItem(new string[] { card.Name, card.Description }));
            }
        }

        private void CardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CardList.SelectedItems.Count > 0)
            {
                CurCard.Name = CardList.SelectedItems[0].SubItems[0].Text;
                CurCard.Description = CardList.SelectedItems[0].SubItems[1].Text;

                CardPreview.Image = (Image)CurCard.FullCard;
            }
        }

        private void setNameFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = CurSettings.NameFont;

            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurSettings.NameFont = fontDialog1.Font;
                CurCard.Template = CurSettings;
                CardPreview.Image = (Image)CurCard.FullCard;
            }
        }

        private void setDescriptionFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = CurSettings.DescriptionFont;

            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurSettings.DescriptionFont = fontDialog1.Font;
                CurCard.Template = CurSettings;
                CardPreview.Image = (Image)CurCard.FullCard;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurSettings.Front = new Bitmap(FrontArtBox.Text);
            CardsheetGenerator.GenerateSheet(ListOfCards, CurSettings)
                .Save(System.IO.Path.Combine(OutputDirBox.Text, "sheet.png"), System.Drawing.Imaging.ImageFormat.Png);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FrontArtBox.Text = openFileDialog1.FileName;

                CurSettings.Front = new Bitmap(FrontArtBox.Text);
                CurCard.Template = CurSettings;
                CardPreview.Image = (Image)CurCard.FullCard;
            }
        }


    }
}
