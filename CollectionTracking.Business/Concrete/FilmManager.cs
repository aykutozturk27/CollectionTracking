using CollectionTracking.Business.Abstract;
using CollectionTracking.Business.ValidationRules.FluentValidation;
using CollectionTracking.Core.Utilities;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace CollectionTracking.Business.Concrete
{
    public class FilmManager : IFilmService
    {
        private IFilmDal _filmDal;

        public FilmManager(IFilmDal filmDal)
        {
            _filmDal = filmDal;
        }

        public void Add(Film film)
        {
            ValidationTool.Validate(new FilmValidator(), film);
            _filmDal.Add(film);
        }

        public void Delete(Film film)
        {
            try
            {
                _filmDal.Delete(film);
            }
            catch
            {
                throw new Exception("Silme başarısız");
            }
        }

        public List<Film> GetAll()
        {
            return _filmDal.GetList();
        }

        public void Update(Film film)
        {
            ValidationTool.Validate(new FilmValidator(), film);
            _filmDal.Update(film);
        }
    }
}
