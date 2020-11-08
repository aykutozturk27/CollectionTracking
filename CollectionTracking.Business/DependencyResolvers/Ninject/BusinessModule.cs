using CollectionTracking.Business.Abstract;
using CollectionTracking.Business.Concrete;
using CollectionTracking.DataAccess.Abstract;
using CollectionTracking.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace CollectionTracking.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFilmService>().To<FilmManager>().InSingletonScope();
            Bind<IFilmDal>().To<EfFilmDal>().InSingletonScope();
        }
    }
}
