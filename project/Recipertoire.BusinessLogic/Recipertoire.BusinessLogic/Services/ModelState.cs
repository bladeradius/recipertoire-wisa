using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Recipertoire.BusinessLogic.Services
{
    class ModelState : IModelState
    {
        private ModelStateDictionary m_ModelState;

        public ModelState(ModelStateDictionary modelState) 
        {
            m_ModelState = modelState;
        }

        public void AddModelError(string key, string error)
        {
            m_ModelState.AddModelError(key, error);
        }

        public bool IsValid { get { return m_ModelState.IsValid; } }
    }
}
