using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire
{
    internal class Program
    {
        public static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Data2>().As<IData>();
            Container = builder.Build();

            Exemple2 exemple1 = new Exemple2() {  };

            int result = exemple1.GetMaxNumber(new Data());
            Console.WriteLine($" le résultat est : {result}");
            Console.ReadLine();
        }
    }
}
