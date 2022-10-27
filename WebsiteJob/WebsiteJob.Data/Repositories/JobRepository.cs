using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IJobRepository : IRepository<Job>
    {
        IEnumerable<Job> GetByAlias(string alias);
    }
    public class JobRepository : RepositoryBase<Job>, IJobRepository
    {
        public JobRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<Job> GetByAlias(string alias)
        {
            return this.DbContext.Jobs.Where(x => x.Alas == alias);
        }
    }
}
