using _77_CheckSSLCertificate.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _77_CheckSSLCertificate.Tests.ModelsTests
{
    public class UnitTests1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void Method1Test()
        {
            var ModelOneObj = new ModelOne();
            var result = ModelOneObj.Method1();
            var expectedResult = "This test is succesful.";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Method2Test()
        {
            var ModelOneObj = new ModelOne();
            var result = ModelOneObj.Method2();
            var expectedResult = "There is a problem. Certificate TestCertificate is NOT found";
            Assert.Equal(expectedResult, result);
        }
    }
}
