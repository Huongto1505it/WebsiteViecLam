using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IVisitorStatisticRepository
    {

    }
    class VisitorStatisticRepository:RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
