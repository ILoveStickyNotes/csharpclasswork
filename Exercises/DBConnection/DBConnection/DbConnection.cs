using System;

namespace DBConnection
{
    public abstract class DbConnection
    {
        private string _ip;
        private TimeSpan _timeOut;
        
        public abstract void OpenConnection();
        public abstract void CloseConnection();

        public DbConnection(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                throw new InvalidOperationException("ip is empty");
            _ip = ip;
        }
        
    }
}