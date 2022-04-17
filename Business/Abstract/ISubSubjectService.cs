using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubSubjectService
    {
        SubSubject GetById(int id);
        List<SubSubject> GetAll();
        void Delete(SubSubject entity);
        void Update(SubSubject entity);
        void Add(SubSubject entity);
    }
}
