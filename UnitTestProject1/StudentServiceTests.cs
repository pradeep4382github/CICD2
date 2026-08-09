using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class StudentServiceTests
    {
        [TestMethod]
        public void GetAll_ShouldReturnSeededStudents()
        {
            var service = new StudentService();
            // Act
            var students = service.GetAll();
            // Assert


            Assert.IsNotNull(students);
            Assert.AreEqual(2, students.Count);
            Assert.AreEqual("John", students[0].Name);
            Assert.AreEqual("David", students[1].Name);
        }
    }
}
