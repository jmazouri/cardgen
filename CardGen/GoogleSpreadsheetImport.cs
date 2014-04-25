using Google.GData.Client;
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

            SpreadsheetQuery query = new SpreadsheetQuery();
            SpreadsheetFeed feed = service.Query(query);

            var sheetquery = feed.Entries.Where(d => d.Id.AbsoluteUri ==
                String.Format("https://spreadsheets.google.com/feeds/spreadsheets/private/full/{0}", settings.SheetID));

            if (!sheetquery.Any())
            {
                throw new ArgumentException("That spreadsheet ID does not exist or you don't have access to it.");
            }

            var cursheet = sheetquery.First();

            AtomLink link = cursheet.Links.FindService(GDataSpreadsheetsNameTable.WorksheetRel, null);

            WorksheetQuery wquery = new WorksheetQuery(link.HRef.ToString());
            WorksheetFeed wfeed = service.Query(wquery);

            AtomLink cellFeedLink = wfeed.Links.FindService(GDataSpreadsheetsNameTable.CellRel, null);

            CellQuery cquery = new CellQuery(cellFeedLink.HRef.ToString());
            CellFeed cfeed = service.Query(cquery);

            foreach (CellEntry curCell in feed.Entries)
            {
                Console.WriteLine("Row {0}, column {1}: {2}", curCell.Cell.Row,
                    curCell.Cell.Column, curCell.Cell.Value);
            }

            Console.WriteLine("Cells in this worksheet:");
            foreach (CellEntry curCell in feed.Entries)
            {
                    Console.WriteLine("Row {0}, column {1}: {2}", curCell.Cell.Row,
                    curCell.Cell.Column, curCell.Cell.Value);
            }

  

            return ret;
        }
    }
}
