using Core.Concrete.EfEntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfSubSubjectDal:EfEntityRepositoryBase<SubSubject,DevelopersDbContext>,ISubSubjectDal
    {
    }
}
