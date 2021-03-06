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
        public void OpPlus() // сложение
        {
            //  Assert.Fail();
             int[] a = new int[] { 17, 2, 3, 4, 5 };
              int[] b = new int[] { 2, 3, 8, 4, 10 };
               var  message = Many.OpPlus(a,b);
            // var message = Many.OpPlus(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Assert.AreEqual("2 3 4 5 8 10 17", message);

        }

        [TestMethod()]
        public void Union()  //умножение
        {
            //  Assert.Fail();
            int[] a = new int[] { 17, 20, 0, 4, 5 };
            int[] b = new int[] { 20, 0, 8, 5, 10 };
            var message = Many.Union(a, b);
            // var message = Many.OpPlus(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Assert.AreEqual("0 5 20", message);

        }


        [TestMethod()]
        public void difference()  //разность
        {
            //  Assert.Fail();
            int[] a = new int[] { 17, 20, 0, 4, 5 };
            int[] b = new int[] { 20, 0, 8, 5, 10 };
           // string s = Many.Union(a, b);
            string message = Many.difference( a, b);


            // var message = Many.OpPlus(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Assert.AreEqual("0 4 17", message);

        }

        [TestMethod()]
        public void addNumber()  //добавление элемента
        {
            int[] a = new int[] { 17, 2, 3, 4, 5 };
            int[] b = new int[] {8};
            var message = Many.OpPlus(a, b);
            Assert.AreEqual("2 3 4 5 8 17", message);

        }

        [TestMethod()]
        public void deleteNumber()  //удаление элемента
        {
            //  Assert.Fail();
            int[] a = new int[] { 17, 20, 2, 4, 5 };
            int[] b = new int[] { 20 };
            // string s = Many.Union(a, b);
            string message = Many.difference(a, b);


            // var message = Many.OpPlus(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 });
            Assert.AreEqual("2 4 5 17", message);

        }
    }
}