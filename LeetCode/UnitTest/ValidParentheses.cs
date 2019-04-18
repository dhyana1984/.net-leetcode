using LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class ValidParentheses
    {
        Dictionary<string, bool> dict = new Dictionary<string, bool>();
        [TestMethod]
        public void TestValidParentheses1()
        {


            dict["()"] = true;
            dict["(()"] = false;
            dict["[{({})}]"] = true;
            dict["([)}"] = false;
            dict["{[(}]}"] = false;
            dict["{[([)}]]"] = false;
            dict["{{{[[()]]}}}"] = true;
            dict["       ()"] = true;
            dict["(   {}  [])"] = true;
            dict["{[({])}]"] = false;
            dict["([[[[[]]]}})"] = false;

            SolutionValidParentheses solution = new SolutionValidParentheses();

            foreach (var item in dict)
            {
                Assert.AreEqual(solution.IsValidParentheses(item.Key), dict[item.Key]);
            }


        }
        [TestMethod]
        public void TestValidParentheses2()
        {

            string s = "(([]){})";

            dict[s] = true;


            SolutionValidParentheses solution = new SolutionValidParentheses();


            Assert.AreEqual(solution.IsValidParentheses(s), dict[s]);


        }
        [TestMethod]
        public void TestValidParentheses3()
        {


            dict["(]"] = false;


            SolutionValidParentheses solution = new SolutionValidParentheses();


            Assert.AreEqual(solution.IsValidParentheses("(]"), dict["(]"]);


        }
        [TestMethod]
        public void TestValidParentheses4()
        {

          

            dict["([)]"] = false;


            SolutionValidParentheses solution = new SolutionValidParentheses();


            Assert.AreEqual(solution.IsValidParentheses("([)]"), dict["([)]"]);


        }
        [TestMethod]
        public void TestValidParentheses5()
        {

     

            dict["{[]}"] = true;

            SolutionValidParentheses solution = new SolutionValidParentheses();


            Assert.AreEqual(solution.IsValidParentheses("{[]}"), dict["{[]}"]);

        }
    }
}
