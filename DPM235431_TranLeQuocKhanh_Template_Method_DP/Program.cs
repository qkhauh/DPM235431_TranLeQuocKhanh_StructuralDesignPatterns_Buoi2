using DPM235431_TranLeQuocKhanh_Template_Method_DP.Clients;
using DPM235431_TranLeQuocKhanh_Template_Method_DP.ConcreteClasses;

namespace DPM235431_TranLeQuocKhanh_Template_Method_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            Console.ReadLine();
        }
    }
}
