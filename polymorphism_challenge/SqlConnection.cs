using System;

namespace polymorphism_challenge
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string ConnectionString) : base(ConnectionString) { }


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
