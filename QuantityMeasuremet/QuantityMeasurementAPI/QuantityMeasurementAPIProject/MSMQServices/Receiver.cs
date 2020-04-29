using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurementAPIProject.MSMQService
{
    public class Receiver
    {
        public void ReceiveData()
        {
            
            MessageQueue MyQueue = null;
            string FilePath = @"C:\Users\stsum\OneDrive\Documents\VSProjects\QuantityMeasurementAPIProjectFolder\QuantityMeasuremet\QuantityMeasurementAPI\QuantityMeasurementAPIProject\MSMQServices\MessageReceivedFile.txt";
            //StreamWriter streamWriter = new StreamWriter(FilePath,true);
            try
            {

                MyQueue = new MessageQueue(@".\Private$\MyQueue");
                Message[] messagesArray = MyQueue.GetAllMessages();
                if (messagesArray.Length > 0)
                {
                    foreach (Message message in messagesArray)
                    {
                        message.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                        string messagebody = message.Body.ToString();
                      
                        MyQueue.Receive();
                       // streamWriter.Write(messagebody);
                      //  File.WriteAllText(FilePath, messagebody);
                       File.AppendAllText(FilePath, messagebody);
                    }
                }
                else
                {
                    Console.WriteLine("No New Messages in Message Queue");
                }
                MyQueue.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MyQueue.Close();
            }
        }

    }
}
