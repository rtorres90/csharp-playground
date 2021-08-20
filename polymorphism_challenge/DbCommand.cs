using System;

namespace polymorphism_challenge
{
    class DbCommand
    {
        private readonly string _commandString;
        private readonly DbConnection _databaseConnection;

        public DbCommand(string CommandString, DbConnection DatabaseConnection)
        {
            if (CommandString is string && DatabaseConnection is DbConnection)
            {
                _commandString = CommandString;
                _databaseConnection = DatabaseConnection;
            }
            else
            {
                throw new Exception("Parameters to initialize this object have to be the expected.");
            }
        }

        public void Execute()
        {
            this._databaseConnection.OpenConnection();
            Console.WriteLine("Executing command: {0}", this._commandString);
            this._databaseConnection.CloseConnection();
        }
    }
}
