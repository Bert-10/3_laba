using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3_laba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_laba.Tests
{
    [TestClass()]
    public class ManyTests
    {
        [TestMethod()]
        public void OpPlus()
        {
            //  Assert.Fail();
             int[] a = new int[] { 17, 2, 3, 4, 5 };
              int[] b = new int[] { 2, 3, 8, 4, 10 };
               var  message = Many.OpPlus(a,b);
            // var message = Many.OpPlus(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Assert.AreEqual("1 2 3 4 5 6 7 8 9 10 ", message);

        }

        [TestMethod()]
        public void Union()
        {
            //  Assert.Fail();
            int[] a = new int[] { 17, 20, 0, 4, 5 };
            int[] b = new int[] { 20, 0, 8, 5, 10 };
            var message = Many.Union(a, b);
            // var message = Many.OpPlus(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Assert.AreEqual("1 2 3 4 5 6 7 8 9 10 ", message);

        }




    }
}