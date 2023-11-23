using EasyLiTwo.Database.Infrastructure.Factory.Interfaces;
using EasyLiTwo.Database.Infrastructure.Shared;
using System.Data;
using System.Data.SQLite;

namespace EasyLiTwo.Database.Infrastructure.Factory
{
    public class Sqlite : ISqlFactory
    {
        public IDbConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={System.Windows.Forms.Application.StartupPath}\\{Map.GetMainDatabaseName()}");
        }
    }
}
