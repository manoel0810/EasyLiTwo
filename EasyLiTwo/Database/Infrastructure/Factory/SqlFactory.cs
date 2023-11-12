using EasyLiTwo.Database.Infrastructure.Shared;
using System.Data;
using System.Data.SQLite;

namespace EasyLiTwo.Database.Infrastructure.Factory
{
    public class SqlFactory
    {
        public IDbConnection SQLiteConnectionsFactory()
        {
            return new SQLiteConnection($"Data Source={System.Windows.Forms.Application.StartupPath}\\{Map.GetMainDatabaseName()}");
        }
    }
}
