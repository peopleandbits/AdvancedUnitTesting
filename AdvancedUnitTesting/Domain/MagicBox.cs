using System;

namespace AdvancedUnitTesting.Domain
{
    public class MagicBox
    {
        public string MyMethod(int a)
        {
            if (a == 3)
            {
                ErgebnisseReady?.Invoke(this, new MyEventArgs("Hello"));
                return null;
            }
            else
                return "Thanks";
        }

        public event EventHandler<MyEventArgs> ErgebnisseReady;

        public class MyEventArgs : EventArgs
        {
            public MyEventArgs(string msg) : base() { this.Message = msg; }
            public string Message { get; private set; }
        }
    }
}
