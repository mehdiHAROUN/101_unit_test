using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUnitaire;

namespace TestUnitaireTests
{
    [TestClass]
    public class Exemple1Test
    {
        [TestMethod]
        public void AllPositive_ReturnsOk()
        {
            // Arrange
            int result = 7;
            string path = @"C:\source\101_unit_test\TestUnitaire\ressource\exemple.txt";

            // Act
            Exemple1 exemple1 = new Exemple1();
            int actual = exemple1.GetMaxNumber(path);

            // Assert
            Assert.AreEqual(result, actual);
        }
    }
}
