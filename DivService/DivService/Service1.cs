using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DivService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public int div(int n1, int n2)
        {
            //.net Exception
            //if (n2 == 0)
            //  throw new FaultException("Cannot divide by zero");
            try
            {
                return n1 / n2;
            }
            catch(DivideByZeroException obj)
            {
                DivideFault divideFault = new DivideFault();
                divideFault.Error = obj.Message;
                divideFault.Details = "Denominator cannot be zero";
                throw new FaultException<DivideFault>(divideFault);
            }
        }
    }
}
