using System;

namespace _19_ResourceLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Orm
    {
        private Database database;

        public Orm(Database database)
        {
            this.database = database;
        }

        public void Write(string data)
        {
        
            try 
            {
                using (var db = database)
                {
                    db.BeginTransaction();
                    db.Write(data);
                    if (data == "bad commit")
                        throw new InvalidOperationException();
                }
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }

        public bool WriteSafely(string data)
        {
            try
            {
                Write(data);
                return true;
            }
            catch
            {
                return false;
            }
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


}
