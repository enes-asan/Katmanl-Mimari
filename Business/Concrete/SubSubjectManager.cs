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
    public class SubSubjectManager : ISubSubjectService
    {
        ISubSubjectDal __subSubjectDal;
        public SubSubjectManager(ISubSubjectDal SubSubjectDal)
        {
            __subSubjectDal= SubSubjectDal;
        }
        public void Add(SubSubject entity)
        {
            __subSubjectDal.Add(entity);
        }

        public void Delete(SubSubject entity)
        {
            __subSubjectDal.Delete(entity);
        }

        public List<SubSubject> GetAll()
        {
            return __subSubjectDal.GetAll();
        }

        public SubSubject GetById(int id)
        {
            return __subSubjectDal.Get(p=>p.Id==id);
        }

        public void Update(SubSubject entity)
        {
            __subSubjectDal.Update(entity);
        }
    }
}
