using System;

namespace AdapterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inheritanceAdapter = new InheritanceAdapter();
            var compositionAdapter = new CompositionAdapter();

            inheritanceAdapter.Build();
            Console.WriteLine($"We have decorated the event room - {inheritanceAdapter.Decorated}");

            compositionAdapter.Build();
            Console.WriteLine($"We have decorated the event room - {compositionAdapter.EventRoom.Decorated}");

            Console.ReadLine();
        }
    }
}
