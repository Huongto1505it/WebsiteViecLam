using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface IEmployerRepository
    {

    }
    class EmployerRepository:RepositoryBase<Employer>
    {
        public EmployerRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
