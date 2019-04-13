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

            var transactionA = new Transaction
            {
                AffiliationCode = "0303",
                TransactionType = TransactionType.ECommerce,
                Amount = 100.00
            };

            var transactionB = new Transaction
            {
                AffiliationCode = "0101",
                TransactionType = TransactionType.ECommerce,
                Amount = 101.00
            };

            var transactionC = new Transaction
            {
                AffiliationCode = "0202",
                TransactionType = TransactionType.ECommerce,
                Amount = 97.00
            };

            afiliationActor.Tell(transactionA);
            afiliationActor.Tell(transactionB);
            afiliationActor.Tell(transactionC);


            Console.Read();
        }
    }
}
