using System;
using Akka.Actor;
using AkkaConsoleSimpleTwoActorsCall.Domain;
using AkkaConsoleSimpleTwoActorsCall.ValueObj;

namespace AkkaConsoleSimpleTwoActorsCall.Actors
{
    public class AfiliationActor : ReceiveActor
    {
        public AfiliationActor()
        {
            Receive<Transaction>(transaction =>
            {
                if ((transaction.AffiliationCode == "0101") || (transaction.AffiliationCode == "0202"))
                {
                    var authorizationActor = Context.ActorOf(Props.Create(() => new AuthorizationActor()));

                    authorizationActor.Tell(transaction);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Authorization Response Code: 72 - Not authorized, invalid affiliation code");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            });
        }

    }
}
