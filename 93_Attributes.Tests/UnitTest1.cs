using System.Security;

namespace _93_Attributes.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(Permission.Read, Permissions.Default(AccountType.Guest));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(Permission.Read, Permissions.Grant(current: Permission.None, grant: Permission.Read));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(Permission.None, Permissions.Revoke(current: Permission.Read, revoke: Permission.Read));
        }

        [Fact]
        public void Test4()
        {
            Assert.False(Permissions.Check(current: Permission.Write, check: Permission.Read));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal("Read, Write", (Permission.Read | Permission.Write).ToString());
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal("All", (Permission.Read | Permission.Write | Permission.Delete).ToString());
            Assert.Equal(Permission.Read | Permission.Write, Permissions.Default(AccountType.User));
            Assert.Equal(Permission.None, Permissions.Default((AccountType)123));
            Assert.Equal(Permission.All, Permissions.Grant(Permission.Read | Permission.Write, Permission.Delete));
            Assert.Equal(Permission.Read, Permissions.Revoke(Permission.Read, Permission.None));
            Assert.Equal(Permission.Delete, Permissions.Revoke(Permission.Write | Permission.Delete, Permission.Read | Permission.Write));
            Assert.Equal(Permission.None, Permissions.Revoke(Permission.Read | Permission.Write, Permission.All));
            Assert.True(Permissions.Check(Permission.Read | Permission.Write, Permission.Read));
            Assert.False(Permissions.Check(Permission.Read | Permission.Write, Permission.Read | Permission.Delete));
        }
    }
}