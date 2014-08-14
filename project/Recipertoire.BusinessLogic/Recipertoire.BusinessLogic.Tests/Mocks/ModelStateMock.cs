using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipertoire.BusinessLogic.Services;

namespace Recipertoire.BusinessLogic.Tests.Mocks
{
    class ModelStateMock : IModelState
    {
        private Dictionary<string, string> m_ModelState;

        public ModelStateMock(Dictionary<string, string> modelState)
        {
            m_ModelState = modelState;
        }

        public void AddModelError(string key, string error)
        {
            m_ModelState.Add(key, error);
            IsValid = false;
        }

        public bool IsValid { get; set; }
    }
}
