using Google.GData.Spreadsheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGen
{
    public class GoogleSpreadsheetImport
    {
        public static List<Card> Import(GoogleSpreadsheetImportSettings settings)
        {
            List<Card> ret = new List<Card>();

            SpreadsheetsService service = new SpreadsheetsService("lectern-bot");
            service.setUserCredentials(settings.Username, settings.Password);

            SpreadsheetQuery query = new SpreadsheetQuery(settings.SheetID);
            SpreadsheetFeed feed = service.Query(query);

            foreach (SpreadsheetEntry entry in feed.Entries)
            {
                Console.WriteLine(entry.Title.Text);
            }



            return ret;
        }
    }
}
