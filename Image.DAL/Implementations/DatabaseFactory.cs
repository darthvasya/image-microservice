using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.DAL.Contracts;
using Image.Model;

namespace Image.DAL.Implementations
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private Entities dataContext;
        public Entities Get()
        {
            return dataContext ?? (dataContext = new Entities());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
