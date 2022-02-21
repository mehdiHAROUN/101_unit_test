using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exemple1 exemple1 = new Exemple1();
            int result = exemple1.GetMaxNumber(@"C:\source\cegid-xrp-flex\testUnitaire\TestUnitaire\ressource\exemple.txt");
            Console.WriteLine($" le résultat est : {result}");
            Console.ReadLine();
        }
    }
}
