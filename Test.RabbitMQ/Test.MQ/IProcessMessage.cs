using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MQ
{
    /// <summary>
    /// 定义一个消息方法，用于消息传递
    /// </summary>
    public interface IProcessMessage
    {
        void ProcessMsg(Message msg);

        Task<string> ProcessMsgAsync(Message msg);
    }
}
