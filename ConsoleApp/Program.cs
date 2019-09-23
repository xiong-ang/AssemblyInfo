using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Version: {AssemblyInfoHelper.Helper.Instance.GetVersion()}");
            Console.WriteLine($"Company: {AssemblyInfoHelper.Helper.Instance.GetCompanyName()}");
            Console.WriteLine($"Product: {AssemblyInfoHelper.Helper.Instance.GetProductName()}");
            Console.WriteLine($"Copyright: {AssemblyInfoHelper.Helper.Instance.GetCopyright()}");
        }
    }
}
