using System.ComponentModel;

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
        public string SheetId { get; set; }

        public GoogleSpreadsheetImportSettings()
        {
            Username = "";
            Password = "";
            SheetId = "";
        }
    }
}
