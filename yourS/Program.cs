using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace yourS
{
    class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<ServiceController>(s =>
                {
                    s.ConstructUsing(name => new ServiceController());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("MyFirstService");
                x.SetDisplayName("MyFirstService");
                x.SetServiceName("MyFirstService");
            });
        }
    }
}
