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

        GoogleSpreadsheetImportSettings GoogleSettings = new GoogleSpreadsheetImportSettings();

        public BatchProcessor()
        {
            InitializeComponent();
        }

        private void BatchProcessor_Load(object sender, EventArgs e)
        {

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
                List<Card> cards = GoogleSpreadsheetImport.Import(GoogleSettings);

                CardList.Clear();
                foreach (Card card in cards)
                {
                    CardList.Items.Add(new ListViewItem(new string[] { card.Name, card.Description }));
                }
            }
        }

        
    }
}
