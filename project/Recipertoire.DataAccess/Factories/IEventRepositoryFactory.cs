using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.DataAccess.Repositories;

namespace Recipertoire.DataAccess.Factories
{
    public interface IEventRepositoryFactory
    {
        public IEventRepository GetRepository();
    }
}
