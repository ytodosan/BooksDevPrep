using NUnit.Framework;
using Terrasoft.Configuration.UsrLibrary;

namespace UsrLibrary.Tests
{
    [TestFixture]
    public class UsrBookCategorizerTests
    {
        [TestCase(1949, true,  TestName = "1949 is classic (just inside threshold)")]
        [TestCase(1950, false, TestName = "1950 is not classic (exact boundary)")]
        [TestCase(2000, false, TestName = "2000 is not classic (recent book)")]
        [TestCase(0,    false, TestName = "0 is not classic (unknown-year sentinel)")]
        public void IsClassic_returns_expected(int year, bool expected) {
            bool actual = UsrBookCategorizer.IsClassic(year);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}