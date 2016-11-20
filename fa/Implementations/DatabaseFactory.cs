using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMicro.DAL.Contracts;
using ImageMicro.Model;

namespace ImageMicro.DAL.Implementations
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private ImageEntities dataContext;
        public ImageEntities Get()
        {
            return dataContext ?? (dataContext = new ImageEntities());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
