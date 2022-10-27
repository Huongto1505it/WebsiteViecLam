using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IJobCategoryRepository : IRepository<JobCategory>
    {
        IEnumerable<JobCategory> GetByAlias(string alias);
    }
   public class JobCategoryRepository: RepositoryBase<JobCategory>,IJobCategoryRepository
    {
        public JobCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<JobCategory> GetByAlias(string alias)
        {
            return this.DbContext.JobCategories.Where(x => x.Alas == alias);
        }
    }
}
