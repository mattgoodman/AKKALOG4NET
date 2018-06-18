using Akka.Actor;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKKALOG4NET
{
    class Program
    {
        static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            var sys = ActorSystem.Create("test");
            log.Debug("log");
            Console.WriteLine("waiting");
            Console.ReadLine();
        }
    }
}
