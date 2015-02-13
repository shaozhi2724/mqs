using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace DQS.DbService
{
    public interface IDbService
    {
        //操作契约
        [OperationContract]
        string SayHelloToUser(string name);

    }
}
