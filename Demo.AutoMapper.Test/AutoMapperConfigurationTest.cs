using NUnit.Framework;
using System;

namespace Demo.AutoMapper.Test
{
    [TestFixture]
    public class AutoMapperConfigurationTest
    {
        private Person person = new Person();
        private PersonDto personDto = new PersonDto();

        [SetUp]
        public void AutoMapper_Should_Initialize()
        {
            new AutoMapperStartupTask().Execute();
            person = new Person { Id = 1, Name = "Bill Gates", BirthDate = DateTime.Now };
            personDto = new PersonDto { Id = 1, Name = "Bill Gates", BirthDate = DateTime.Now };
        }

        [Test]
        public void AutoMapper_Should_Use_Request_For_Dto()
        {
            var response = person.MapTo<Person, PersonDto>();
            Assert.AreEqual(personDto.Name, response.Name);
        }

        [Test]
        public void AutoMapper_Should_Use_Response_For_Entity()
        {
            var request = personDto.MapTo<PersonDto, Person>();
            Assert.AreEqual(personDto.Name, request.Name);
        }
    }
}