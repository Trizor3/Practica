using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SomeClass : ISomeInterface
    {
        public void MethodA()
        {
            ISomeInterface me = (ISomeInterface)this;
            me.MethodB();
        }
        void ISomeInterface.MethodB()
        {
            throw new NotImplementedException();
        }
    }
    interface ISomeInterface
    {
        void MethodA();
        void MethodB();
    }
}
