﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.MQ
{
    /// <summary>
    /// 定义消息传递的实体
    /// </summary>
    public class Message
    {
        public string MessageID { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public string MessageRouter { get; set; }
    }
}
