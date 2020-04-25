using Demo.AutoMapper.Class;
using NUnit.Framework;
using System;

namespace Demo.AutoMapper.Test
{
    [TestFixture]
    public class AutoMapperConfigurationTest
    {
        private PeopleRequest peopleRequest = new PeopleRequest();
        private PeopleResponse peopleResponse = new PeopleResponse();

        public void Init()
        {
            peopleRequest = new PeopleRequest { Id = 1, Name = "Bill Gates", BirthDate = DateTime.Now };
            peopleResponse = new PeopleResponse { Id = 1, Name = "Bill Gates", BirthDate = DateTime.Now };
        }

        [Test]
        public void AutoMapper_Should_Initialize()
        {
            new AutoMapperStartupTask().Execute();
            Assert.Pass();
        }

        [Test]
        public void AutoMapper_Should_Use_Request_For_Response()
        {
            var response = MappingExtensions.MapTo<PeopleRequest, PeopleResponse>(peopleRequest);
            Assert.AreEqual(peopleRequest.Name, response.Name);
        }

        [Test]
        public void AutoMapper_Should_Use_Response_For_Request()
        {
            var request = MappingExtensions.MapTo<PeopleResponse, PeopleRequest>(peopleResponse);
            Assert.AreEqual(peopleResponse.Name, request.Name);
        }

        [Test]
        public void AutoMapper_Should_Use_To_Response()
        {
            var request = peopleResponse.ToRequest();
            Assert.AreEqual(request.Name, peopleResponse.Name);
        }

        [Test]
        public void AutoMapper_Should_Use_To_Request()
        {
            var response = peopleRequest.ToResponse();
            Assert.AreEqual(peopleRequest.Name, response.Name);
        }
    }
}