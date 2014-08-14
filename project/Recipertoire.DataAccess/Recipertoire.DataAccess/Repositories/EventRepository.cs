using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipertoire.DataAccess.Models;

namespace Recipertoire.DataAccess.Repositories
{
    class EventRepository : IEventRepository
    {
        private RecipertoireEntities m_Entities = new RecipertoireEntities();

        public IEnumerable<Event> List()
        {
            return m_Entities.Events.ToList();
        }

        public bool Create(Event newEvent)
        {
            try
            {
                m_Entities.Events.Add(newEvent);
                m_Entities.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool Delete(Event existingEvent)
        {
            try
            {
                m_Entities.Events.Remove(existingEvent);
                m_Entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Event existingEvent)
        {
            try
            {
                m_Entities.Entry(existingEvent).State = System.Data.Entity.EntityState.Modified;
                m_Entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
