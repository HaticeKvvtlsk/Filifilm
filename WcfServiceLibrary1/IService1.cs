using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Filmler> FilmleriGetir();
    }
}

