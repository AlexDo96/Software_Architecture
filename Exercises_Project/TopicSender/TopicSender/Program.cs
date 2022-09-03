using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicSender
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
            IConnection con = factory.CreateConnection("admin", "admin");
            con.Start();//nối tới MOM

            ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
            ActiveMQTopic destination = new ActiveMQTopic("thanthidet");

            IMessageProducer producer = session.CreateProducer(destination);
            ActiveMQTextMessage tmsg = new ActiveMQTextMessage("hola. mondo");
            producer.Send(tmsg);

            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
