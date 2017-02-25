using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(100f);
            book.AddGrade(88f);
            GradeStatistics stats = book.ComputerStatistics();
            Assert.AreEqual(100f, stats.HighestGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Name set", book.Name);
        }

        private void SetName(GradeBook book)
        {
            book.Name = "Name set";
        }
    }
}
