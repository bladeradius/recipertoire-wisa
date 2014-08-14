using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.DataAccess.Repositories;
using Recipertoire.DataAccess.Models;

namespace Recipertoire.BusinessLogic.Tests.Mocks
{
    class EventRepositoryMock : IEventRepository
    {
        public bool Create(Event newEvent)
        {
            return true;
        }

        public bool Delete(Event existingEvent)
        {
            return true;
        }

        public bool Edit(Event existingEvent)
        {
            return true;
        }

        public IEnumerable<Event> List()
        {
            return new List<Event>();
        }
    }
}
