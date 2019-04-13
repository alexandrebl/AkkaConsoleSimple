using System;
using System.Threading;
using Akka.Actor;

namespace AkkaConsoleSimple
{
    public class Greet
    {
        public Greet(string who)
        {
            Who = who;
        }
        public string Who { get; private set; }
    }

    public class GreetingActor : ReceiveActor
    {
        public GreetingActor()
        {
            Receive<Greet>(greet =>
                {
                    Console.WriteLine("[Thread {0}] Greeting {1}", Thread.CurrentThread.ManagedThreadId, greet.Who);
                });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("MySystem");
            var greeter = system.ActorOf<GreetingActor>("greeter");
            greeter.Tell(new Greet("Hello World"));

            Console.Read();
        }
    }
}
