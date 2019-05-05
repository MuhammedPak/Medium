using System;
using MediumAppMP.Business.Abstract;
using MediumAppMP.Business.Concrete;
using MediumAppMP.Entities.Concrete;
using Microsoft.Rest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MediumAppMP.Business.Tests
{
    [TestClass]
    public class UserServiceTest
    {
        private IUserService userService;
        public UserServiceTest(IUserService userService)
        {
            this.userService = userService;
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Add()
        {
            var user = new User
            {
                Name = "MpTest"
            };

            userService.Add(user);
        }
    }
}
