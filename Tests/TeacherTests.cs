using NUnit.Framework;
using SimpleLibrary;
using SimpleLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class TeacherTests
    {
        private IStringHelper _stringHelper;

        [SetUp]
        public void Init()
        {
            _stringHelper = new StringHelper();
        }

        [Test]
        public void CheckSubstring()
        {
            var result = _stringHelper.GetMySubsting("123456789", 1, 3);
            Assert.AreEqual("234", result);
        }

        [Test]
        public void CheckNotCallNullException()
        {
            var result = _stringHelper.GetMySubsting(null, 0, null);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void CheckWhenLengthBigThenRealLength()
        {
            var result = _stringHelper.GetMySubsting("123456789", 1, 100);
            Assert.AreEqual("23456789", result);
        }
    }
}
