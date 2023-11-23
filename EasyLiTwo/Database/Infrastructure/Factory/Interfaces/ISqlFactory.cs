using System.Data;

namespace EasyLiTwo.Database.Infrastructure.Factory.Interfaces
{
    public interface ISqlFactory
    {
        IDbConnection GetConnection();
    }
}
