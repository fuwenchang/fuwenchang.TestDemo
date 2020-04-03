using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.MQ;

namespace Test.Cosumer
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessMessage order = new OrderProcessMessage();
            Message msg = new Message();
            msg.MessageID = 1.ToString();
            msg.MessageRouter = "testKey";

            MQHelper.Subscribe(msg, order);

            //MQHelper.SubscribeAsync(msg, order);

            Console.WriteLine("成功了！");
        }
    }
}
