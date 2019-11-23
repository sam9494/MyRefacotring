using System;

namespace MyRefactoring
{
    public interface IChangeMethod
    {
        string NewMethod();
    }

    public class ChangeMethod : IChangeMethod
    {
        public string NewMethod()
        {
            return "This is New Method";
        }
    }
}