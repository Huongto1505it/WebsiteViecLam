using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteJob.Data.Infrastructure
{
   public class DbFactory : Disposable, IDbFactory
    {
        WebsiteJobDbContext dbContext;
        public WebsiteJobDbContext Init()
        {
            return dbContext ?? (dbContext = new WebsiteJobDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
