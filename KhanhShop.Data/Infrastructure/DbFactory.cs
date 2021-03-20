using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private KhanhShopDbContext dbContext;

        public KhanhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new KhanhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
