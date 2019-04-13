using System;
using Akka.Actor;
using AkkaConsoleSimpleTwoActors.Actors;
using AkkaConsoleSimpleTwoActors.Domain;

namespace AkkaConsoleSimpleTwoActors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("ReportSystem");
            var reportActor = system.ActorOf<ReportActor>("greeter");

            reportActor.Tell(new Person { Age = 38, Name = "Joe Satriani" });
            reportActor.Tell(new Person { Age = 28, Name = "Steve Vai" });
            reportActor.Tell(new Company { TaxDocument = "68363562525", Description = "Transportadora X"});
            reportActor.Tell(new Company { TaxDocument = "12341341334", Description = "Transportadora W" });
            reportActor.Tell(new Company { TaxDocument = "56778746746", Description = "Transportadora L" });
            reportActor.Tell(new Company { TaxDocument = "75794749467", Description = "Transportadora Z" });

            Console.Read();
        }
    }
}
