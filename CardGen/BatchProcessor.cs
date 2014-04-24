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
            if (comboBox1.SelectedIndex == 0)
            {
                propertyGrid1.SelectedObject = GoogleSettings;
            }
        }

        
    }
}
