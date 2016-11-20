using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMicro.Model;

namespace ImageMicro.DAL.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        ImageEntities Get();
    }
}
