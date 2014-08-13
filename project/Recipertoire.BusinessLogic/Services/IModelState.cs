using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipertoire.BusinessLogic.Services
{
    public interface IModelState
    {
        void AddModelError(string key, string error);
        bool IsValid { get; }
    }
}
