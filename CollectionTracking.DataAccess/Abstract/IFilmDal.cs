using CollectionTracking.Core.DataAccess;
using CollectionTracking.Entities.Concrete;

namespace CollectionTracking.DataAccess.Abstract
{
    public interface IFilmDal : IEntityRepository<Film>
    {
    }
}
