using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DCS.Model;

namespace DCS.Test
{
    [TestClass]
    public class UserTest
    {
        private List<User> _repository = new List<User>();
        public UserTest()
        {
            _repository.Add(new User("teste", "teste", "teste"));
            _repository.Add(new User("joana", "joana", "joana"));
            _repository.Add(new User("Priscila", "MayogaX", "123456"));
        }

        [TestMethod]
        public void Create_New_User_Get_Valid_Id()
        {
            User user = new User("João", "João", "654321");
            Assert.IsNotNull(user.Id);
        }

        [TestMethod]
        public void Try_Login_Unsuccessfully()
        {
          //  UserBl bl = new UserBl();
        }
    }
}
