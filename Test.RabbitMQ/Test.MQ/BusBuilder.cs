using EasyNetQ;
using EasyNetQ.Consumer;
using EasyNetQ.Logging;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MQ
{
    /// <summary>
    /// 管道创建类，主要负责连接Rabbitmq
    /// </summary>
    public class BusBuilder
    {
        public static IBus CreateMessage()
        {
            //消息服务器连接字符串
            const string connString = "host=127.0.0.1:5672;virtualHost=OrderQueue;username=fuwenchang;password=fuwenchang123";
            if (string.IsNullOrEmpty(connString))
            {
                throw new Exception("messageserver connection string is messing or empty");
            }           
            return RabbitHutch.CreateBus(connString);
        }

        public static IAdvancedBus CreateAdvancedBus()
        {
            ConnectionFactory connectFactory = new ConnectionFactory();
            connectFactory.HostName = "127.0.0.1";
            connectFactory.VirtualHost = "OrderQueue";
            connectFactory.UserName = "fuwenchang";
            connectFactory.Password = "fuwenchang123";
            
            
            RabbitAdvancedBus bus = new RabbitAdvancedBus(connectFactory);

            
        }
        
    }
}
