using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipertoire.BusinessLogic.Tests.Mocks;
using Recipertoire.BusinessLogic.Factories;
using Recipertoire.BusinessLogic.Services;
using Recipertoire.DataAccess.Models;

namespace Recipertoire.BusinessLogic.Tests
{
    [TestClass]
    public class EventServiceTest
    {
        [TestMethod]
        public void TestValidateEventComments()
        {
            var modelState = new Dictionary<string, string>();

            ModelStateMock modelStateMock = new ModelStateMock(modelState);
            EventRepositoryMock eventRepository = new EventRepositoryMock();

            DefaultEventServiceFactory serviceFactory = new DefaultEventServiceFactory(eventRepository);

            IEventService service = serviceFactory.GetService();

            Event validateEvent = new Event();
            validateEvent.Comments = string.Empty;

            bool valid = service.ValidateEvent(validateEvent, modelStateMock);

            Assert.IsFalse(valid);
            Assert.AreEqual(true, modelState.ContainsKey("Comments"));

            validateEvent.Comments = "Has comments";

            modelState.Clear();
            modelStateMock.IsValid = true;
            valid = service.ValidateEvent(validateEvent, modelStateMock);

            Assert.IsTrue(valid);
        }
    }
}
