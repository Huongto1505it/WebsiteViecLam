using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteJob.Data.Infrastructure;
using WebsiteJob.Model.Models;

namespace WebsiteJob.Data.Repositories
{
    public interface ICandidateRepository
    {

    }
   public class CandidateRepository:RepositoryBase<Candidate>,ICandidateRepository
    {
        public CandidateRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
