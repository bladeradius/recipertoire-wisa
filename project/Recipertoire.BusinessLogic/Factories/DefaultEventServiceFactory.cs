using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.BusinessLogic.Services;
using Recipertoire.DataAccess.Repositories;

namespace Recipertoire.BusinessLogic.Factories
{
    public class DefaultEventServiceFactory : IEventServiceFactory
    {
        IEventRepository m_EventRepository;

        public DefaultEventServiceFactory(IEventRepository eventRepository)
        {
            m_EventRepository = eventRepository;
        }

        public Reciptertoire.BusinessLogic.Services.IEventService GetService()
        {
            return new EventService(m_EventRepository);
        }
    }
}
