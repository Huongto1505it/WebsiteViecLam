using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IsysdiagramRepository
    {

    }
  public  class sysdiagramRepository:RepositoryBase<sysdiagram>,IsysdiagramRepository
    {
        public sysdiagramRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
