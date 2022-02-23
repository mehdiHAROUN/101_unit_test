using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using TestUnitaire;

namespace TestUnitaireTests
{
    [TestClass]
    public class Exemple2Test
    {
        private MockRepository mockRepository;

        [TestInitialize]
        public void Setup()
        {
            mockRepository = new MockRepository(MockBehavior.Strict) { DefaultValue = DefaultValue.Mock };
        }

        [TestMethod]
        public void AllPositive_ReturnsOk()
        {
            // Arrange
            int result = 7;
            string[] vs = new string[] { "0", "1", "2" };

            var mockDataAccess = new Mock<IData>();
            mockDataAccess.Setup(it => it.GetData()).Returns(vs);

            // Act
            Exemple2 exemple2 = new Exemple2() {   };
            int actual = exemple2.GetMaxNumber(mockDataAccess.Object);

            // Assert
            Assert.AreEqual(result, actual);
        }
    }
}
