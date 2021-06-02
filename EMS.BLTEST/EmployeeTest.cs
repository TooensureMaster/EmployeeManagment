using EMS.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EMS.BLTEST
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Employee employee = new Employee
            {
                FirstName = "Shawn",
                MiddleName = "Delaine",
                LastName = "Bellazan",
            };

            //-- Sort
            string expect = "Bellazan, D, Shawn";

            //-- Act
            string actual = employee.FullName;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Employee employee = new Employee
            {
                MiddleName = "delaine",
                LastName = "Bellazan"
            };

            //-- Sort
            string expect = "Bellazan, D";

            //-- Act
            string actual = employee.FullName;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Employee employee = new Employee
            {
                FirstName = "Shawn",
                MiddleName = "D",
            };

            //-- Sort
            string expect = "D, Shawn";

            //-- Act
            string actual = employee.FullName;

            Assert.AreEqual(expect, actual);
        }
    }
}
