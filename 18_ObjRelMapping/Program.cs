using System;

namespace _18_ObjRelMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Database : IDisposable
    {
        public static State State { get; internal set; }
        public State DbState { get; set; }

        public void Dispose()
        {
            DbState = State.Closed;
        }

        internal void BeginTransaction()
        {
            if (DbState == State.Closed)
                DbState = State.TransactionStarted;
            else
                throw new Exception();
        }

        internal void Write(string data)
        {
            if (DbState == State.TransactionStarted && data != "bad write")
                DbState = State.DataWritten;
            else if (DbState == State.TransactionStarted && data == "bad write")
                {
                    DbState = State.Invalid;
                    throw new Exception();
                }
        }

        internal void EndTransaction()
        {
            if (DbState == State.DataWritten)
                DbState = State.Closed;
        }
    }

    public enum State
    {
        Closed,
        TransactionStarted,
        DataWritten,
        Invalid
    }

    public class Orm :IDisposable
    {
        private Database database;

        public Orm(Database database)
        {
            this.database = database;
        }

        public void Begin()
        {
             if (database.DbState != State.Closed)
                throw new InvalidOperationException ("Database state is " + database.DbState);
            database.BeginTransaction();
        }

        public void Write(string data)
        {
            try {
                    if (database.DbState == State.TransactionStarted )
                        {
                            database.Write(data);
                        }
            }
            catch{
                    database.Dispose();
            }
        }

        public void Commit()
        {
            try {
                database.EndTransaction();
            }
            catch
            {
                database.Dispose();
            }
        }

        public void Dispose()
        {
            database.Dispose();
        }
    }
}
