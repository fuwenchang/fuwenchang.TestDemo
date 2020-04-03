using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.MQ
{
    /// <summary>
    /// 用于正在的订阅和发布消息
    /// </summary>
    public class MQHelper
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="msg"></param>
        public static void Publish(Message msg)
        {
            //创建消息Bus
            IBus bus = BusBuilder.CreateMessage();
            try
            {
                bus.Publish(msg, x => x.WithTopic(msg.MessageRouter));



            }
            catch (Exception)
            {
                //错误消息处理
            }
            //使用完后记得销毁
            bus.Dispose();
        }

        //public static void PublishFanout(Message msg)
        //{
        //    var bus = BusBuilder.CreateMessage();
        //    try
        //    {
        //        if (bus.IsConnected)
        //        {
        //            var exchange=bus.
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }
        //}

        /// <summary>
        /// 接受消息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ipro"></param>
        public static void Subscribe(Message msg, IProcessMessage ipro)
        {
            //创建消息Bus
            IBus bus = BusBuilder.CreateMessage();
            try
            {
                bus.Subscribe<Message>(msg.MessageRouter, m => ipro.ProcessMsg(m), x => x.WithTopic(msg.MessageRouter));
            }
            catch (Exception)
            {
                //错误消息处理
            }
        }

        /// <summary>
        /// 异步接受消息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ipro"></param>
        public static void SubscribeAsync(Message msg, IProcessMessage ipro)
        {
            IBus bus = BusBuilder.CreateMessage();
            try
            {
                bus.SubscribeAsync<Message>(msg.MessageRouter, m => ipro.ProcessMsgAsync(m));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
