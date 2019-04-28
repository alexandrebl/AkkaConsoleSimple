using System;
using Akka.Actor;
using AkkaConsoleSimpleTwoActorsCall.Actors;
using AkkaConsoleSimpleTwoActorsCall.Domain;
using AkkaConsoleSimpleTwoActorsCall.ValueObj;

namespace AkkaConsoleSimpleTwoActorsCall
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("ReportSystem");
            var afiliationActor = system.ActorOf<AfiliationActor>(nameof(AfiliationActor));

            var transactionA = new Transaction(TransactionType.ECommerce, 100.00, "0101");
            var transactionB = new Transaction(TransactionType.ECommerce, 101.00, "0202");
            var transactionC = new Transaction(TransactionType.ECommerce, 97.00, "0303");

            afiliationActor.Tell(transactionA);
            afiliationActor.Tell(transactionB);
            afiliationActor.Tell(transactionC);

            Console.Read();
        }
    }
}
