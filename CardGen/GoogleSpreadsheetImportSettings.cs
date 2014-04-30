using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGen
{
    public class GoogleSpreadsheetImportSettings
    {
        [DisplayName("Username")]
        
        [Description("The username for a google account with access to the spreadsheet.")]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Description("The password for the account.")]
        [PasswordPropertyText(true)]
        public string Password { get; set; }

        [DisplayName("Spreadsheet Name")]
        [Description("Exact title of the spreadsheet document.")]
        public string SheetID { get; set; }

        [DisplayName("Tab Name")]
        [Description("Exact name of the tab to import from.")]
        public string TabName { get; set; }

        public GoogleSpreadsheetImportSettings()
        {
            Username = "";
            Password = "";
            SheetID = "";
            TabName = "Sheet1";
        }
    }
}
