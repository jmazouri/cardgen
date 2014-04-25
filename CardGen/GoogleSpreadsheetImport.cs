using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var db = client.GetDatabase(settings.SheetID);
            var t = db.GetTable<Card>("Sheet1");

            return ret;
        }
    }
}
