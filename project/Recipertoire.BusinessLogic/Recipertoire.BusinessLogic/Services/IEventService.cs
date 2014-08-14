using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.DataAccess.Models;

namespace Recipertoire.BusinessLogic.Services
{
    public interface IEventService
    {
        bool ValidateEvent(Event newEvent, IModelState modelState);
    }
}
