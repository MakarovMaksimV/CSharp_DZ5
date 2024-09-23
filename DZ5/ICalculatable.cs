using System;
namespace DZ5
{
    public interface ICalculatable
    {
        event EventHandler<EventArgs> GotResult;
        public void Add(int value);
        public void Sub(int value);
        public void Multy(int value);
        public void Div(int value);
        public void CancelLast();
        public void Reset();
        public bool CloseApp();
    }
}



