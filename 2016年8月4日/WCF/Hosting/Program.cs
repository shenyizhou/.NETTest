using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using Server;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1/calculatorservice");

                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behaviour = new ServiceMetadataBehavior();
                    behaviour.HttpGetEnabled = true;
                    behaviour.HttpGetUrl = new Uri("http://127.0.0.1/calculatorservice/metadata");
                    host.Description.Behaviors.Add(behaviour);
                }

                host.Opened += new EventHandler(host_Opened);
                
                host.Open();
                Console.Read();
            }
        }

        static void host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("打开成功！");
        }
    }
}
