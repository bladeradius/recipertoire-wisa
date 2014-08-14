using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.BusinessLogic.Services;

namespace Recipertoire.BusinessLogic.Factories
{
    public interface IEventServiceFactory
    {
        IEventService GetService();
    }
}
