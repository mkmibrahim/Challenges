using System;
using System.Collections.Generic;
using Xunit;

namespace _09_Initializers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var authenticator = new Authenticator();
            //Identity expectedResult = new Identity()
            //                            {"admin@ex.ism", {"green", 0.9m}, ["Chanakya", "Mumbai", "India"]};

            var result = authenticator.Admin;
            var expecteResult = new Identity()
            {
                Email = "admin@ex.ism", 
                FacialFeatures = new FacialFeatures() {EyeColor = "green", PhiltrumWidth = 0.9m}, 
            NameAndAddress = new List<string>(){"Chanakya", "Mumbai", "India"}
            };
            Assert.Equal(expecteResult, result);

// => 
        }
    }
}
