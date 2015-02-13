using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace DQS.DbService
{
    public class DbSvr:IDbService
    {
        #region IDbService 成员

        public string SayHelloToUser(string name)
        {
            OperationContext context = OperationContext.Current;

            //获取传进的消息属性
            MessageProperties properties = context.IncomingMessageProperties;

            //获取消息发送的远程终结点IP和端口
            RemoteEndpointMessageProperty endpoint = properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;

            

            Console.WriteLine(string.Format("Hello {0},You are   from {1}:{2}", name, endpoint.Address, endpoint.Port));

            return string.Format("Hello {0},You are   from {1}:{2}", name, endpoint.Address, endpoint.Port);

        }

        #endregion
    }
}
