using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Akka.Actor;
using AkkaConsoleSimpleTwoActors.Domain;
using AkkaConsoleSimpleTwoActors.Library;
using Newtonsoft.Json;

namespace AkkaConsoleSimpleTwoActors.Actors
{
    public class ReportActor : ReceiveActor
    {
        private ReportCompanyProcess _reportCompanyProcess = new ReportCompanyProcess();
        public ReportActor()
        {
            Receive<Person>(message =>
            {
                Console.WriteLine($"Person data: {JsonConvert.SerializeObject(message)}\n\n");
            });

            Receive<Company>(message =>
            {
                _reportCompanyProcess.SendReport(message);
            });
        }
        
    }
}
