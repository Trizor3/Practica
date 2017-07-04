using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IDatabase
    {
        void Connect(string connectionString);
        void Close();
        object GetData();
        void SendData(object data);
    }
}
