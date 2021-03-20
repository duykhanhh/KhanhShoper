using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        KhanhShopDbContext Init();
    }
}
