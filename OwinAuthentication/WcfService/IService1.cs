using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IList<Usuario> FindAll();     
    }
}
