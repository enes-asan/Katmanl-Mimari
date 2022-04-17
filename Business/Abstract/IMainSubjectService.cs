using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMainSubjectService
    {
        MainSubject GetById(int id);
        List<MainSubject> GetAll();
        void Delete(MainSubject entity);
        void Update(MainSubject entity);
        void Add(MainSubject entity);
    }
}
