using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.DataAccess.Models;

namespace Recipertoire.DataAccess.Repositories
{
    public interface IEventRepository
    {
        IEnumerable<Event> List();
        bool Create(Event newEvent);
        bool Delete(Event existingEvent);
        bool Edit(Event existingEvent);
    }
}
