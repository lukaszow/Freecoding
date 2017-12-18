using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordIterating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordIterating.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            var expectedOutout = "ok";

            var actualOUtput = Program.InvertInput();

            Assert.AreEqual(expectedOutout, actualOUtput);
        }
    }
}