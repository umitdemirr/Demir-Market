using System.Data.OleDb;
namespace StokTakip
{
    public class DbContext
    {
        static string baglantiYolu = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\App_Data\\VeriTabanı.mdb";
        public OleDbConnection connection = new OleDbConnection(baglantiYolu);        
    }
}