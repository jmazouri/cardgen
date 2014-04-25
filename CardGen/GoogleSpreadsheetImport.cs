using System.Collections.Generic;
using GDataDB;
using GDataDB.Linq;

namespace CardGen
{
    public class GoogleSpreadsheetImport
    {
        public static List<Card> Import(GoogleSpreadsheetImportSettings settings)
        {
            List<Card> ret = new List<Card>();

            var client = new DatabaseClient(settings.Username, settings.Password);

            var db = client.GetDatabase(settings.SheetId);
            var t = db.GetTable<Card>("Sheet1");

            return ret;
        }
    }
}
