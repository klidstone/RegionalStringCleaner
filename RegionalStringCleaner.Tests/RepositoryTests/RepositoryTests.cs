using Moq;
using NUnit.Framework;
using RegionalStringCleaner.Repository;
using System.Collections.Generic;
using RegionalStringCleaner.Models;
using System;

namespace RegionalStringCleaner.Tests.RepositoryTests
{
    [TestFixture]
    public class RepositoryTests
    {
        private Mock<IStringCleanerRepository> _stringCleanerRepository;

        private Dictionary<char, string> _successfulCharacterMapReturn = new Dictionary<char, string>
        {
            ['é'] = "e"
        };

        private string _successfulStringPatternReturn = "";

        private Region _region = Region.Epc;

        [Test]
        public void TestSuccessfulStringPatternReturn()
        {
            _stringCleanerRepository = new Mock<IStringCleanerRepository>();
            _stringCleanerRepository.Setup(x => x.GetAcceptableStringPatternForRegion(_region)).Returns(_successfulStringPatternReturn);

            var result = _stringCleanerRepository.Object.GetAcceptableStringPatternForRegion(_region);

            Assert.True(_successfulStringPatternReturn.Equals(result));
        }

        [Test]
        public void TestSuccessfulCharacterMapReturn()
        {
            _stringCleanerRepository = new Mock<IStringCleanerRepository>();
            _stringCleanerRepository.Setup(x => x.GetCharacterMappingsForRegion(_region)).Returns(_successfulCharacterMapReturn);

            var result = _stringCleanerRepository.Object.GetCharacterMappingsForRegion(_region);

            Assert.True(_successfulCharacterMapReturn.Equals(result));
        }
    }
}
