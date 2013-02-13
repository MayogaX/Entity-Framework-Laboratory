using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DCS.Model;

namespace DCS.Test
{
    [TestClass]
    public class ExempleTest
    {
        [TestMethod]
        public void Create_New_Exemple_Get_Valid_Id()
        {
            Exemple exemple = new Exemple("New test");
            Assert.IsNotNull(exemple.Id);
        }
    }
}
