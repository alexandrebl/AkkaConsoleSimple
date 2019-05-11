using System;
using Akka.Actor;
using AkkaConsoleSimpleTwoActorsCall.Domain;
using AkkaConsoleSimpleTwoActorsCall.Library;

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

                    authorizationActor.GracefulStop(new TimeSpan(10000));
                }
                else
                {
                    ConsoleUtility.PrintMsg("Authorization Response Code: 72 - Not authorized, invalid affiliation code", false);                    
                }
            });
        }
    }
}
