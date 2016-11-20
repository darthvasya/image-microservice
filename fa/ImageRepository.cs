using ImageMicro.DAL.Contracts;
using ImageMicro.DAL.Implementations;
using ImageMicro.Model;

namespace ImageMicro.Repository
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        private ImageEntities dataContext;

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public ImageRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected ImageEntities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
    }

    public interface IImageRepository : IRepository<Image>
    { }
}
