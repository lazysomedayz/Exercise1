using System.Diagnostics;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ChangeCash changeCash = new ChangeCash();
            changeCash.menu();
        }
    }
}