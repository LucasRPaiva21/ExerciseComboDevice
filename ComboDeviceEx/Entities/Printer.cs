using System;

namespace ComboDeviceEx.Entities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        void IPrinter.Printer(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }
    }
}
