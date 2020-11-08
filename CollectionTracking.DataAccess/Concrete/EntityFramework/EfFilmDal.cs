using CollectionTracking.Core.DataAccess.EntityFramework;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.Entities.Concrete;

namespace CollectionTracking.DataAccess.Concrete.EntityFramework
{
    public class EfFilmDal : EfEntityRepositoryBase<Film, CollectionTrackingContext>,IFilmDal
    {
    }
}
