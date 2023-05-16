using System;
using Xunit;

namespace _18_ObjRelMapping.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var orm = new Orm(new Database());
            orm.Begin();
            // => database has an internal state of State.TransactionStarted
        }

        [Fact]
        public void Test2()
        {
            var database = new Database();
            var orm = new Orm(database);
            orm.Begin();
            //orm.Write("some data");
            //Assert.Equal(State.DataWritten, database.DbState);
            // => database has an internal state of State.DataWritten
            orm.Write("bad write");
            Assert.Equal(State.Closed, database.DbState);
            // => database has an internal state of State.Closed
        }

        [Fact]
        public void Test3()
        {
            var orm = new Orm(new Database());
            orm.Begin();
            orm.Write("some data");
            orm.Commit();
            // => database has an internal state of State.Closed
            orm.Begin();
            orm.Write("bad commit");
            orm.Commit();
            // => database has an internal state of State.Closed
        }

        [Fact]
        public void Test4()
        {
            var db = new Database();
            var orm = new Orm(db);
            orm.Begin();
            orm.Write("some data");
            orm.Dispose();
            Assert.Equal(State.Closed, db.DbState);// => database has an internal state of State.Closed
        }
    }
}
