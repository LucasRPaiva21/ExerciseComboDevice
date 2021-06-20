using System;

namespace ComboDeviceEx.Entities
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner procesing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
