using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaire
{
    public class Exemple2
    {
        public int GetMaxNumber()
        {
            Data data = new Data(); 
            string[] lines = data.getData();

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

    public class Data
    {
        public string[] getData()
        {
            return System.IO.File.ReadAllLines(@"C:\source\cegid-xrp-flex\testUnitaire\TestUnitaire\ressource\exemple.txt");
        }
    }
}
