using System;

namespace polymorphism_challenge
{
    class DbConnection
    {
        protected string ConnectionString { get; }
        protected TimeSpan Timeout;

        public DbConnection(string ConnectionString)
        {
            if (ConnectionString is string)
            {
                this.ConnectionString = ConnectionString;
            }
            else
            {
                throw new Exception($"The ConnectionString is not a string as expected. Obtained: {ConnectionString.GetType()}");
            }
        }

        public virtual void OpenConnection() { }

        public virtual void CloseConnection() { }

    }
}
