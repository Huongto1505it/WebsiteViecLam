using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IMenuRepository
    {

    }
   public class MenuRepository:RepositoryBase<Menu>,IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
