using System;

namespace MyRefactoring
{
    public interface IChangeMethod
    {
        string NewMethod();
    }

    public class ChangeMethod : IChangeMethod
    {
        public static string OldMethod()
        {
            //return "This is Old Method";
            return null;
        }

        public string NewMethod()
        {
            return "This is New Method";
        }
    }
}