using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.DataAccess.Factories;
using Recipertoire.DataAccess.Repositories;
using Recipertoire.DataAccess.Models;

namespace Recipertoire.BusinessLogic.Services
{
    class EventService : IEventService
    {
        private IEventRepository m_Repository;

        public EventService(IEventRepository repository)
        {
            m_Repository = repository;
        }

        public bool ValidateEvent(Event newEvent, IModelState modelState)
        {
            if (newEvent.Comments.Trim().Length == 0)
            {
                modelState.AddModelError("Comments", "Comments are undefined.");
            }

            return modelState.IsValid;
        }
    }
}
