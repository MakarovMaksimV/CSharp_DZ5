using System;
namespace DZ5
{
    public class Calculator : ICalculatable
    {
        public int Result = 0;

        public event EventHandler<EventArgs> GotResult;

        private Stack<int> stack = new Stack<int>();

        public void Add(int value)
        {
            stack.Push(Result);
            Result += value;
            RiseEvent();
        }
        public void Sub(int value)
        {
            stack.Push(Result);
            Result -= value;
            RiseEvent();
        }

        public void Div(int value)
        {
            stack.Push(Result);
            Result /= value;
            RiseEvent();
        }

        public void Multy(int value)
        {
            stack.Push(Result);
            Result *= value;
            RiseEvent();
        }

        public void CancelLast()
        {
            if (stack.Count > 0)
            {
                Result = stack.Pop();
                RiseEvent();
            }
        }

        public void Reset()
        {
            stack.Clear();
            Result = 0;
            RiseEvent();
        }

        private void RiseEvent()
        {
            GotResult.Invoke(this, EventArgs.Empty);
        }

        public bool CloseApp()
        {
            return false;
        }
    }
}





