using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurementAPIProject.MSMQService
{
    public class Sender
    {
        public void SendMessage(string MessageToSend)
        {
            MessageQueue MyQueue = null;
            //System.IO.StreamWriter sr = new System.IO.StreamWriter();
            try
            {
                if (MessageQueue.Exists(@".\Private$\MyQueue"))
                {
                    MyQueue = new MessageQueue(@".\Private$\MyQueue");
                }
                else
                {
                    MyQueue = MessageQueue.Create(@".\Private$\MyQueue");
                }

                MyQueue.Label = "This is the test Queue";
                MyQueue.Send(MessageToSend, "dataconversion");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MyQueue.Dispose();
            }
        }
    }
}
