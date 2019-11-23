using System;

namespace MyRefactoring
{
    public interface IChangeMethod
    {
        string OldMethod();
        string NewMethod();
    }

    public class ChangeMethod : IChangeMethod
    {
        public string OldMethod()
        {
            return "This is Old Method";
        }

        public string NewMethod()
        {
            return "This is New Method";
        }
    }
}