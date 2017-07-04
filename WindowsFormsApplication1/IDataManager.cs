using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IDataManager
    {
        object GetData(IConnectionManager connManager);
        void SendData(IConnectionManager connManager, object data);    }
}
