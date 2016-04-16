using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourS
{
    public class ServiceController
    {
        private bool _isServiceAllowedToRun;

        readonly Task _task;

        public ServiceController()
        {
            _isServiceAllowedToRun = true;
            _task = new Task(ServiceControllerRoutine);
        }

        private void ServiceControllerRoutine()
        {
            while (_isServiceAllowedToRun)
            {
                Console.WriteLine("Vanichka-Sone4ko");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void Start() { _task.Start(); }
        public void Stop()
        {
            _isServiceAllowedToRun = false;
            Console.WriteLine("Service was stopped");
            Console.ReadLine();
        }
    }
}
