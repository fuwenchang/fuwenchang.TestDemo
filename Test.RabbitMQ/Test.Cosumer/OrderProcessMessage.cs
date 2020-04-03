using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test.MQ;

namespace Test.Cosumer
{
    public class OrderProcessMessage : IProcessMessage
    {
        public string Print(Message msg)
        {
            Thread.Sleep(5000);
            Console.WriteLine(msg.MessageTitle);
            return "ok";
        }

        public void ProcessMsg(Message msg)
        {
            Thread.Sleep(5000);
            Console.WriteLine(msg.MessageTitle);
        }

        public async Task<string> ProcessMsgAsync(Message msg)
        {
            return await Task.Run(() => Print(msg));
        }
    }
}
