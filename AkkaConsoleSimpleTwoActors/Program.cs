using System;
using Akka.Actor;
using AkkaConsoleSimpleTwoActorsCall.Actors;
using AkkaConsoleSimpleTwoActorsCall.Domain;
using AkkaConsoleSimpleTwoActorsCall.ValueObj;

namespace AkkaConsoleSimpleTwoActorsCall
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var system = ActorSystem.Create("TransactionSystem");
            var afiliationActor = system.ActorOf<AffiliationActor>(nameof(AffiliationActor));
            
            var transactionA = new Transaction(TransactionType.ECommerce, 100.00, "0101");
            var transactionB = new Transaction(TransactionType.TEF, 101.00, "0202");
            var transactionC = new Transaction(TransactionType.TEF, 97.00, "0303");

            afiliationActor.Tell(transactionA);
            afiliationActor.Tell(transactionB);
            afiliationActor.Tell(transactionC);

            Console.Read();
        }
    }
}
