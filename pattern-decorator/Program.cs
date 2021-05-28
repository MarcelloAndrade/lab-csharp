using System;

namespace pattern_decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestConcreteComponent();
            TestNotifier();
        }

        public static void TestConcreteComponent(){
            var simple = new ConcreteComponent();
            Console.WriteLine($"1- Simple: {simple.Operation()}");
            Console.WriteLine();

            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(simple);
            Console.WriteLine($"2- decoratorA: {decoratorA.Operation()}");
            Console.WriteLine();
            
            ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
            Console.WriteLine($"3- decoratorB: {decoratorB.Operation()}");
            Console.WriteLine();
        }

        public static void TestNotifier(){
            var notifier = new NotifierConcrete();
            notifier.Send("This is basic message");

            var notifierEmail = new NotifierEmail(notifier);
            notifierEmail.Send("This is a e-mail");

            var notifierSMS = new NotifierSMS(notifier);
            notifierSMS.Send("This is a SMS");
        }
    }
}
