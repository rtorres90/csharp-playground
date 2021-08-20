using System;

namespace polymorphism_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("localhost");
            DbCommand dbCommand = new DbCommand("select * from lmao;", sqlConnection);
            dbCommand.Execute();
            OracleConnection oracleConnection = new OracleConnection("prod");
            DbCommand dbCommand2 = new DbCommand("select * from lmao;", oracleConnection);
            dbCommand2.Execute();
        }
    }
}
