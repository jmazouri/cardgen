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

        [DisplayName("Spreadsheet ID")]
        [Description("ID taken from the URL of the spreadsheet.")]
        public string SheetID { get; set; }

        public GoogleSpreadsheetImportSettings()
        {
            Username = "jmazouri";
            Password = "thepasswordformyemailaccount";
            SheetID = "15bqiuV7EV8276xtrKqm4bjbsvjMAA4c7-_8S0a9AwJg";
        }
    }
}
