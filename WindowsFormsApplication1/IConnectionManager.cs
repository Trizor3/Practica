using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IConnectionManager
    {
        void Close();
        void Connect();
    }
    public class SqlConnectionManager : IConnectionManager
    {
        public void Close()
        {
            Console.WriteLine("Closed SQL Server connection...");
        }
        public void Connect()
        {
            Console.WriteLine("Connected to SQL Server!");
        }
    }
    public class OracleConnectionManager : IConnectionManager
    {
        public void Close()
        {
            Console.WriteLine("Closed Oracle connection...");
        }
        public void Connect()
        {
            Console.WriteLine("Connected to Oracle!");
        }
        

    }
   
}
