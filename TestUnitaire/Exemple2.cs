using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire
{
    public class Exemple2
    {
        public int GetMaxNumber(IData data)
        {
            //string[] lines = data.GetData();
            string[] lines = Program.Container.Resolve<IData>().GetData();

            int result = 0;

            foreach (string line in lines)
            {
                if (result < Convert.ToInt32(line))
                {
                    result = Convert.ToInt32(line);
                }
            }
            return result;
        }
    }



    public class Data : IData
    {
        public string[] GetData()
        {
            return System.IO.File.ReadAllLines(@"C:\source\101_unit_test\TestUnitaire\ressource\exemple.txt");
        }

    }
    public class Data2 : IData
    {
        public string[] GetData()
        {
            return System.IO.File.ReadAllLines(@"C:\source\101_unit_test\TestUnitaire\ressource\exemple.txt");
        }

    }

    public interface IData
    {
        string[] GetData();
    }
}
