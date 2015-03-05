using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    [ServiceContract]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }
}
