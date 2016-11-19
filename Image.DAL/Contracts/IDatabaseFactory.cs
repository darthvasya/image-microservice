using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.Model;

namespace Image.DAL.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        Entities Get();  
    }
}
