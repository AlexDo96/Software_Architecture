using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
namespace Subcriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press enter to exit");
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();//nối tới MOM
            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQTopic destination = new ActiveMQTopic("thanthidet");
            IMessageConsumer producer = session.CreateConsumer(destination);
            IMessage msg = new ActiveMQTextMessage("Hola Anh");
            Producer_Listener(msg);
            producer.Listener += Producer_Listener;
            Console.ReadLine();
        }
        private static void Producer_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage tmsg = message as ActiveMQTextMessage;
                String txt = tmsg.Text;
                Console.WriteLine(txt);
            }
        }
    }
}
