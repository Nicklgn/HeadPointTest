using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using HeadPointTest;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        public static string ToAssertableString(IDictionary<string, List<string>> dictionary)
        {
            var pairStrings = dictionary.OrderBy(p => p.Key).Select(p => p.Key + ": " + string.Join(", ", p.Value));
            return string.Join("; ", pairStrings);
        }

        [TestMethod]
        public void Array()
        {
            Dictionary<string, List<string>> expected = new();
            expected["кот"] = new List<string> { "ток", "кот", " то" };
            expected["орст"] = new List<string> { "рост", "торс" };
            expected["авпфы"] = new List<string> { "фывап" };
            expected["кор"] = new List<string> { "рок" };

            string[] array = { "ток", "рост", "кот", "торс", " то", "фывап", "рок" };
            Dictionary<string, List<string>> result = TestClass.GetResult(array);

            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result));
        }

        [TestMethod]
        public void List()
        {
            Dictionary<string, List<string>> expected = new();
            expected["кот"] = new List<string> { "ток", "кот", " то" };
            expected["орст"] = new List<string> { "рост", "торс" };
            expected["авпфы"] = new List<string> { "фывап" };
            expected["кор"] = new List<string> { "рок" };

            List<string> list = new() { "ток", "рост", "кот", "торс", " то", "фывап", "рок" };
            Dictionary<string, List<string>> result = TestClass.GetResult(list);

            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result));
        }


        [TestMethod]
        public void Null()
        {
            Dictionary<string, List<string>> expected = new();
            Dictionary<string, List<string>> result = TestClass.GetResult(null);

            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result));
        }

        [TestMethod]
        public void Empty()
        {
            Dictionary<string, List<string>> expected = new();
            Dictionary<string, List<string>> result = TestClass.GetResult(System.Array.Empty<string>());

            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result));
        }

        [TestMethod]
        public void EmptyString()
        {
            Dictionary<string, List<string>> expected = new();
            Dictionary<string, List<string>> result = TestClass.GetResult(new string[] { string.Empty });

            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result));
        }

        [TestMethod]
        public void NullString()
        {
            Dictionary<string, List<string>> expected = new();
            Dictionary<string, List<string>> result = TestClass.GetResult(new string[] { null });

            Assert.AreEqual(ToAssertableString(expected), ToAssertableString(result));
        }
    }
}
