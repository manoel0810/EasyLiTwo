using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLiTwo.Database.Infrastructure.Factory
{
    public interface ISqlFactory
    {
        IDbConnection GetConnection();
    }
}
