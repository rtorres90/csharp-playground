using System;

namespace polymorphism_challenge
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string ConnectionString) : base(ConnectionString) { }


        public override void OpenConnection()
        {
            Console.WriteLine("Connection opened to {0}", this.ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection closed to {0}", this.ConnectionString);
        }
    }
}
