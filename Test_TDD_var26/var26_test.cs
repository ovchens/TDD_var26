using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_var26;
namespace Test_TDD_var26
{
    [TestClass]
    public class var26_test
    {
        [TestMethod]
        public void birthday_Check_test_02111989_Expected_true()
        {
            DateTime date = new DateTime(1989, 11, 02);
            
            bool actual= var26.birthday_Check(date);

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void birthday_Check_test_12021999_Expected_false()
        {
            DateTime date = new DateTime(1999, 02, 12);

            bool actual = var26.birthday_Check(date);

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
