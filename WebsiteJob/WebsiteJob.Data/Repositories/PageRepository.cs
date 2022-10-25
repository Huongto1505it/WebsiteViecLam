using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IPageRepository
    {

    }
   public class PageRepository:RepositoryBase<Page>,IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
