using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratory;

namespace Laboratory
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void IsSuccessful_ImportantTrue_Test()
        {
            bool expected = true;
            Test current = Test.ConductTest("1", "02-02-1999 05:05:05", "02-02-1999 06:06:06", "petrov", 100, Test.Typical[0]);

            Assert.AreEqual(expected, current.IsSuccessful());
        }


        [TestMethod]
        public void IsSuccessful_ImportantFalse_Test()
        {

        }


        [TestMethod]
        public void IsSuccessful_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsSuccessful_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_2_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_3_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_2_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_3_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_1_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_2_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_3_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_1_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_2_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantTrue_3_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantFalse_1_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantFalse_2_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantFalse_3_UsualTrue_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantFalse_1_UsualFalse_Test()
        {

        }



        [TestMethod]
        public void IsChecked_1_ImportantFalse_2_UsualFalse_Test()
        {

        }


        [TestMethod]
        public void IsChecked_1_ImportantFalse_3_UsualFalse_Test()
        {

        }
    }
}
