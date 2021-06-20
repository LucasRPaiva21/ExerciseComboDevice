using System;

namespace ComboDeviceEx.Entities
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public void Printer(string document)
        {
            throw new NotImplementedException();
        }

        public override void ProcessDoc(string document)
        {
            throw new NotImplementedException();
        }

        public string Scan()
        {
            throw new NotImplementedException();
        }
    }
}
