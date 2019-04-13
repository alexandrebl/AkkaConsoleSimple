using System;
using System.Collections.Generic;
using System.Text;
using Akka.Actor;
using AkkaConsoleSimpleTwoActorsCall.Domain;
using AkkaConsoleSimpleTwoActorsCall.ValueObj;

namespace AkkaConsoleSimpleTwoActorsCall
{
    public class AuthorizationActor : ReceiveActor
    {
        public AuthorizationActor()
        {
            Receive<Transaction>(transaction =>
            {
                if (((transaction.TransactionType == TransactionType.ECommerce) && (transaction.Amount < 100)) ||
                    ((transaction.TransactionType != TransactionType.ECommerce) && (transaction.Amount >= 10)))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Authorization Response Code: 00 - Success");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Authorization Response Code: 51 - Not authorized, invalid payment type");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            });
        }
    }
}
