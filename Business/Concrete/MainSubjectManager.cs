using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MainSubjectManager : IMainSubjectService
    {
        IMainSubjectDal _mainSubjectDal;
        public MainSubjectManager(IMainSubjectDal mainSubjectDal)
        {
            _mainSubjectDal= mainSubjectDal;
        }
        public void Add(MainSubject entity)
        {
            _mainSubjectDal.Add(entity);
        }

        public void Delete(MainSubject entity)
        {
            _mainSubjectDal.Delete(entity);
        }

        public List<MainSubject> GetAll()
        {
            return _mainSubjectDal.GetAll();
        }

        public MainSubject GetById(int id)
        {
            return _mainSubjectDal.Get(p=>p.Id==id);
        }

        public void Update(MainSubject entity)
        {
            _mainSubjectDal.Update(entity);
        }
    }
}
