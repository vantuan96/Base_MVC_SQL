using Kztek.Data.Infrastructure;
using Kztek.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kztek.Data.Repository.StudentRepository;

namespace Kztek.Data.Repository
{
   public class StudentRepository : RepositoryBase<Student> , IStudentRepository
    {
        public StudentRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
        public interface IStudentRepository : IRepository<Student>
        {

        }
    }
}
